using System;
using System.Collections.Generic;

public class Graph
{
    //Atribut
    private string node;
    private Dictionary<string, double> edge = new Dictionary<string, double>();
    private int nEdge;
    private int population;
    private int dayInfection;

    public Graph(string nd)
    //Constructor dengan input nama node nd
    {
        this.node = nd;
        this.nEdge = 0;
        this.population = 2;
        this.dayInfection = -1;
    }

    public string GetNode()
    //Method ambil nilai atribut node
    {
        return this.node;
    }

    public List<string> GetEdge()
    //Method ambil list node yang merupakan pasangan sisi dari node
    {
        List<string> temp = new List<string>();
        Dictionary<string, double>.KeyCollection keys = this.edge.Keys;
        foreach (string key in keys)
        {
            temp.Add(key);
        }
        return temp;
    }

    public double GetChance(string a)
    //Method ambil peluang penyebaran virus ke node a
    {
        return this.edge[a];
    }

    public void AddEdge(string x, double p)
    //Method menambahkan pasangan sisi node x dengan peluang penyebaran p
    {
        this.edge.Add(x, p);
        this.nEdge += 1;
    }

    public int GetNEdge()
    //Method ambil jumlah sisi
    {
        return this.nEdge;
    }

    public int GetPopulation()
    //Method ambil jumlah populasi
    {
        return this.population;
    }

    public void SetPopulation(int p)
    //Method ubah jumlah populasi menjadi p
    {
        this.population = p;
    }

    public int GetDayInf()
    //Method ambil kapan hari terinfeksi
    {
        return this.dayInfection;
    }

    public void SetDayInf(int d)
    //Method ubah kapan hari terinfeksi menjadi d
    {
        this.dayInfection = d;
    }

    public int AffectedPopulation(uint durInf)
    //Method menghitung populasi terkena virus dengan durasi infeksi = durInf
    {
        if (this.GetDayInf() == -1)
        {
            return 0;
        }
        else
        {
            int t = Convert.ToInt32(durInf) - this.GetDayInf();
            double I = Convert.ToDouble(this.GetPopulation() / (1 + (this.GetPopulation() - 1) * (Math.Pow(Math.E, (-0.25 * t)))));
            return Convert.ToInt32(Math.Floor(I));
        }
    }

    public double FungsiPenyebaran(uint durInf, string b)
    //Method fungsi S(this.node,b) yaitu fungsi penyebaran virus dari this.node ke b dengan durasi infeksi = durInf
    {
        return Convert.ToDouble(this.AffectedPopulation(durInf) * this.GetChance(b));
    }

    public int FungsiTersebar(string b)
    //Method waktu infeksi pertama kota b dari penyebaran virus oleh kota this.node
    {
        double e = (this.GetPopulation() * this.GetChance(b) / (this.GetPopulation()));
        double time = Math.Floor(Math.Log(e) * -4) + 1;
        return Convert.ToInt32(time);
    }
}