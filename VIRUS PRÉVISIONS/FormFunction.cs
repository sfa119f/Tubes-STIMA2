using System;
using System.Collections.Generic;
using System.Windows.Forms;

public class FormFunction
{
    //Atribut
    public uint day;
    private int nSimpul, nSisi;
    private string firstInfectionCity;
    private List<string> fileMap = new List<string>();
    private List<string> filePopulasi = new List<string>();
    private Dictionary<string, Graph> graf = new Dictionary<string, Graph>();
    private List<string> queue = new List<string>();
    private List<string> dataHasilPengecekan = new List<string>();

    public void BacaMap(string loc)
    //Method membaca file map yang ada di lokasi "loc"
    {
        fileMap.Clear();
        string[] data = System.IO.File.ReadAllLines(loc);
        foreach (string line in data)
        {
            fileMap.Add(line);
        }
    }

    public void BacaPopulasi(string loc)
    //Method membaca file populasi yang ada di lokasi "loc"
    {
        filePopulasi.Clear();
        string[] data = System.IO.File.ReadAllLines(loc);
        foreach (string line in data)
        {
            filePopulasi.Add(line);
        }
    }

    private void PushNeighboors(string a)
    //Method menambahkan antrian kota yang bertetanggan dengan node a
    {
        foreach (string city in this.graf[a].GetEdge())
        {
            this.queue.Add(a);
            this.queue.Add(city);
        }
    }

    private void AddGraphIfNotExist(string key)
    //Method penambahan node pada atribut graf jika belum ada node key
    {
        if (!this.graf.ContainsKey(key))
        {
            Graph tmp = new Graph(key);
            graf.Add(key, tmp);
        }
    }

    public void SimulasiPenyebaran()
    //Method menjalankan simulasi penyebaran dengan data dari atribut fileMap dan filePopulasi menggunakan algoritma BFS
    {
        //Bersihkan data dulu
        graf.Clear();
        dataHasilPengecekan.Clear();

        //Ambil data dari File Map
        this.nSisi = int.Parse(fileMap[0]);
        for (int i = 0; i < this.nSisi; i++)
        {
            string[] temp = fileMap[i + 1].Split(' ');
            if (temp.Length < 3)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                AddGraphIfNotExist(temp[0]);
                this.graf[temp[0]].AddEdge(temp[1], Convert.ToDouble(temp[2]));
            }
        }

        //Ambil data dari File Populasi
        string[] tmp = filePopulasi[0].Split(' ');
        if (tmp.Length < 2)
        {
            throw new IndexOutOfRangeException();
        }
        else
        {
            this.nSimpul = int.Parse(tmp[0]);
            this.firstInfectionCity = tmp[1];
            AddGraphIfNotExist(firstInfectionCity);
            this.graf[firstInfectionCity].SetDayInf(0);
        }
        for (int i = 0; i < this.nSimpul; i++)
        {
            string[] temp = filePopulasi[i + 1].Split(' ');
            if (temp.Length < 2)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                AddGraphIfNotExist(temp[0]);
                if (Int32.Parse(temp[1]) < 2)
                {
                    throw new OverflowException();
                }
                else
                {
                    this.graf[temp[0]].SetPopulation(Int32.Parse(temp[1]));
                }
            }
        }

        //Simulasi Penyebaran dengan algoritma BFS
        PushNeighboors(this.firstInfectionCity);
        string kotaAsal, kotaTujuan;
        do
        {
            kotaAsal = this.queue[0];
            kotaTujuan = this.queue[1];
            dataHasilPengecekan.Add("(" + kotaAsal + "," + kotaTujuan + ") " + this.graf[kotaAsal].FungsiPenyebaran(day, kotaTujuan).ToString());
            if (this.graf[kotaAsal].FungsiPenyebaran(day, kotaTujuan) > 1 && this.graf[kotaTujuan].GetDayInf() == -1)
            {
                int hari = this.graf[kotaAsal].FungsiTersebar(kotaTujuan);
                this.graf[kotaTujuan].SetDayInf(hari + graf[kotaAsal].GetDayInf());
                PushNeighboors(kotaTujuan);
            }
            queue.RemoveAt(0);
            queue.RemoveAt(0);
        } while (this.queue.Count != 0);
    }

    public void GambarPeta()
    //Method menggabarkan peta penyebaran atribut graf pada form baru
    {
        System.Windows.Forms.Form peta = new System.Windows.Forms.Form();
        Microsoft.Glee.GraphViewerGdi.GViewer view = new Microsoft.Glee.GraphViewerGdi.GViewer();
        Microsoft.Glee.Drawing.Graph map = new Microsoft.Glee.Drawing.Graph("Peta Penyebaran Virus");

        Dictionary<string, Graph>.KeyCollection keys = this.graf.Keys;
        foreach (string node1 in keys)
        {
            if (graf[node1].GetNEdge() == 0)
            {
                map.AddNode(node1);
            }
            else
            {
                foreach (string node2 in graf[node1].GetEdge())
                {
                    map.AddEdge(node1, node2);
                }
                if (graf[node1].GetDayInf() != -1)
                {
                    Microsoft.Glee.Drawing.Node temp = map.FindNode(node1);
                    temp.Attr.Fillcolor = Microsoft.Glee.Drawing.Color.Red;
                }
            }
        }

        //bind the graph to the viewer
        view.Graph = map;

        //associate the viewer with the form
        peta.SuspendLayout();
        view.Dock = System.Windows.Forms.DockStyle.Fill;
        peta.Controls.Add(view);
        peta.ResumeLayout();
        peta.Text = "Peta Penyebaran Virus";
        peta.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

        //show the form
        peta.ShowDialog();
    }

    public void SaveDataToFile(string locToSave)
    //Method penyimpanan data simulasi dengan nama file "DataHasilPenyebaranVirus.txt" pada folder locToSave
    {
        if (locToSave == "")
        {
            throw new System.IO.DirectoryNotFoundException();
        }
        else
        {
            List<string> data = new List<string>();
            data.Add("Lama infeksi: " + day.ToString());
            data.Add("");
            Dictionary<string, Graph>.KeyCollection keys = this.graf.Keys;
            foreach (string node1 in keys)
            {
                data.Add("Kota " + graf[node1].GetNode() + ":");
                if(graf[node1].GetDayInf() < 0)
                {
                    data.Add("Kota tidak terinfeksi virus");
                }
                else
                {
                    data.Add("Terinfeksi hari ke-" + graf[node1].GetDayInf().ToString());
                }
                data.Add("Populasi terinfeksi " + graf[node1].AffectedPopulation(day).ToString() + "/" + graf[node1].GetPopulation().ToString());
                data.Add("");
            }
            data.Add("Hasil fungsi S(X,Y):");
            foreach (string temp in dataHasilPengecekan)
            {
                data.Add(temp);
            }
            string loc = locToSave + "\\" + "DataHasilPenyebaranVirus.txt";
            System.IO.File.WriteAllLines(@loc, data);
        }
    }

    public void ClearAll()
    //Method membuat atribut fileMap, filePopulasi, graf, queue, dan dataHasilPengecekan mempunyai length=0
    {
        fileMap.Clear();
        filePopulasi.Clear();
        graf.Clear();
        queue.Clear();
        dataHasilPengecekan.Clear();
    }
}