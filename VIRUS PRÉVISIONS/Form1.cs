using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuBesSTIMA2
{
    public partial class Virus_Prévisions : Form
    {
        //Atribut
        private FormFunction func = new FormFunction();
        private uint infDay;
        private string folderSaveData = "";

        public Virus_Prévisions()
        //Constructor
        {
            InitializeComponent();
        }

        private void InputMapFile(object sender, EventArgs e)
        //Method tombol input file map
        {
            OpenFileDialog mapFile = new OpenFileDialog();
            if (mapFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string loc = mapFile.FileName;
                MessageBox.Show(loc);
                this.LocMapFile.Text = loc;
                func.BacaMap(loc);
            }

        }

        private void InputPopulationFile(object sender, EventArgs e)
        //Method tombol input file populasi
        {
            OpenFileDialog populationFile = new OpenFileDialog();
            if (populationFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string loc = populationFile.FileName;
                MessageBox.Show(loc);
                this.LocPplFile.Text = loc;
                func.BacaPopulasi(loc);
            }
        }

        private void DirectionFolderSave(object sender, EventArgs e)
        //Method tombol input folder directory
        {
            FolderBrowserDialog temp = new FolderBrowserDialog();
            temp.ShowNewFolderButton = true;
            if (temp.ShowDialog() == DialogResult.OK)
            {
                folderSaveData = temp.SelectedPath;
                this.LocFolderToSave.Text = folderSaveData;
            }
        }

        private void InfDayUpDown(object sender, EventArgs e)
        //Method NumUpDown input day infection menerima text berupa integer
        {
            infDay = Convert.ToUInt32(this.UpDownDayInf.Value);
        }

        private void InfDayUpDown(object sender, KeyEventArgs e)
        //Method NumUpDown input day ketika menerima enter
        {
            if (e.KeyCode == Keys.Enter)
            {
                infDay = Convert.ToUInt32(this.UpDownDayInf.Value);
                MakeMap(this, new EventArgs());
            }
        }

        private void ClearData(object sender, EventArgs e)
        //Method tombol menghapus segala input yang ada
        {
            this.LocPplFile.Text = "";
            this.LocMapFile.Text = "";
            //this.TextBoxDay.Text = "";
            this.UpDownDayInf.Value = 0;
            this.LocFolderToSave.Text = "";
            func.ClearAll();
            this.folderSaveData = "";
        }

        private void MakeMap(object sender, EventArgs e)
        //Method tombol membuat map dari simulasi penyebaran
        {
            try
            {
                func.day = infDay;
                func.SimulasiPenyebaran();
                func.SaveDataToFile(folderSaveData);
                func.GambarPeta();
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Struktur file tidak valid");
            }
            catch (FormatException)
            {
                MessageBox.Show("Format nilai pada masukan file atau data salah");
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Terdapat nilai NULL pada masukan file atau data");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Overflow nilai pada masukan file atau data");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Tidak ada masukan file");
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                MessageBox.Show("Direktori penyimpanan tidak valid");
            }
        }
    }
}