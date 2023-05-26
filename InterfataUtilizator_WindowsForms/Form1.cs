using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2_Tema;
using System;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace InterfataUtilizator_WindowsForms
{
    public partial class Form1 : Form
    {
        AdministrareCarti_FisierText adminCarti;


        private Label lblTitlu;
        private Label lblAutor;
        private Label lblAnPublicatie;
        private Label lblSubiectLiterar;
        private Label lblValabilitate;
        private Label lblDetinator;


        private Label[] lblsTitlu;
        private Label[] lblsAutor;
        private Label[] lblsAnPublicatie;
        private Label[] lblsSubiectLiterar;
        private Label[] lblsValabilitate;
        private Label[] lblsDetinator;


        private TextBox boxTitlu;
        private TextBox boxAutor;
        private TextBox boxAnPublicatie;
        private TextBox boxSubiectLiterar;
        private TextBox boxDetinator;

        private Label lblBoxTitlu;
        private Label lblBoxAutor;
        private Label lblBoxAnPublicatie;
        private Label lblBoxSubiectLiterar;
        private Label lblBoxValabilitate;
        private Label lblBoxDetinator;

        private Button BtnAdauga;
        private Button BtnRefresh;


        private const int Latime = 100;
        private const int Dimensiune_Y = 30;
        private const int Dimensiune_X = 100;
        public Form1()
        {

            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            adminCarti = new AdministrareCarti_FisierText(caleCompletaFisier);
            InitializeComponent();

            this.Size = new Size(750, 300);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.ForeColor = Color.Red;
            this.Text = "Informatii carti";

            lblTitlu = new Label();
            lblTitlu.Width = Latime;
            lblTitlu.Text = "Titlu";
            lblTitlu.Left = 0;
            lblTitlu.ForeColor = Color.Green;
            this.Controls.Add(lblTitlu);

            lblAutor = new Label();
            lblAutor.Width = Latime;
            lblAutor.Text = "Autor";
            lblAutor.Left = Dimensiune_X;
            lblAutor.ForeColor = Color.Green;
            this.Controls.Add(lblAutor);

            lblAnPublicatie = new Label();
            lblAnPublicatie.Width = Latime;
            lblAnPublicatie.Text = "An publicatie";
            lblAnPublicatie.Left = 2 * Dimensiune_X;
            lblAnPublicatie.ForeColor = Color.Green;
            this.Controls.Add(lblAnPublicatie);

            lblSubiectLiterar = new Label();
            lblSubiectLiterar.Width = Latime;
            lblSubiectLiterar.Text = "Subiect Literar";
            lblSubiectLiterar.Left = 3 * Dimensiune_X;
            lblSubiectLiterar.ForeColor = Color.Green;
            this.Controls.Add(lblSubiectLiterar);

            lblValabilitate = new Label();
            lblValabilitate.Width = Latime;
            lblValabilitate.Text = "Valabilitate";
            lblValabilitate.Left = 4 * Dimensiune_X;
            lblValabilitate.ForeColor = Color.Green;
            this.Controls.Add(lblValabilitate);

            lblDetinator = new Label();
            lblDetinator.Width = Latime;
            lblDetinator.Text = "Detinator";
            lblDetinator.Left = 5 * Dimensiune_X;
            lblDetinator.ForeColor = Color.Green;
            this.Controls.Add(lblDetinator);

            boxTitlu = new TextBox();
            boxTitlu.Left = 7 * Dimensiune_X;
            boxTitlu.Top = Dimensiune_Y;
            this.Controls.Add(boxTitlu);

            boxAutor = new TextBox();
            boxAutor.Left = 7 * Dimensiune_X;
            boxAutor.Top = 2 * Dimensiune_Y;
            this.Controls.Add(boxAutor);

            boxAnPublicatie = new TextBox();
            boxAnPublicatie.Left = 7 * Dimensiune_X;
            boxAnPublicatie.Top = 3 * Dimensiune_Y;
            this.Controls.Add(boxAnPublicatie);

            boxSubiectLiterar = new TextBox();
            boxSubiectLiterar.Left = 7 * Dimensiune_X;
            boxSubiectLiterar.Top = 4 * Dimensiune_Y;
            this.Controls.Add(boxSubiectLiterar);

            //boxValabilitate = new TextBox();
            //boxValabilitate.Left = 7 * Dimensiune_X;
            //boxValabilitate.Top = 5 * Dimensiune_Y;
            //this.Controls.Add(boxValabilitate);

            boxDetinator = new TextBox();
            boxDetinator.Left = 7 * Dimensiune_X;
            boxDetinator.Top = 6 * Dimensiune_Y;
            this.Controls.Add(boxDetinator);

            lblBoxTitlu = new Label();
            lblBoxTitlu.Width = Latime;
            lblBoxTitlu.Text = "Titlu";
            lblBoxTitlu.Left = 6 * Dimensiune_X;
            lblBoxTitlu.Top = Dimensiune_Y;
            lblBoxTitlu.ForeColor = Color.DarkCyan;
            lblBoxTitlu.TextAlign = ContentAlignment.MiddleRight;
            this.Controls.Add(lblBoxTitlu);

            lblBoxAutor = new Label();
            lblBoxAutor.Width = Latime;
            lblBoxAutor.Text = "Autor";
            lblBoxAutor.Left = 6 * Dimensiune_X;
            lblBoxAutor.Top = 2 * Dimensiune_Y;
            lblBoxAutor.ForeColor = Color.DarkCyan;
            lblBoxAutor.TextAlign = ContentAlignment.MiddleRight;
            this.Controls.Add(lblBoxAutor);

            lblBoxAnPublicatie = new Label();
            lblBoxAnPublicatie.Width = Latime;
            lblBoxAnPublicatie.Text = "An publicatie";
            lblBoxAnPublicatie.Left = 6 * Dimensiune_X;
            lblBoxAnPublicatie.Top = 3 * Dimensiune_Y;
            lblBoxAnPublicatie.ForeColor = Color.DarkCyan;
            lblBoxAnPublicatie.TextAlign = ContentAlignment.MiddleRight;
            this.Controls.Add(lblBoxAnPublicatie);

            lblBoxSubiectLiterar = new Label();
            lblBoxSubiectLiterar.Width = Latime;
            lblBoxSubiectLiterar.Text = "Subiect Literar";
            lblBoxSubiectLiterar.Left = 6 * Dimensiune_X;
            lblBoxSubiectLiterar.Top = 4 * Dimensiune_Y;
            lblBoxSubiectLiterar.ForeColor = Color.DarkCyan;
            lblBoxSubiectLiterar.TextAlign = ContentAlignment.MiddleRight;
            this.Controls.Add(lblBoxSubiectLiterar);

            lblBoxValabilitate = new Label();
            lblBoxValabilitate.Width = Latime;
            lblBoxValabilitate.Text = "Valabilitate";
            lblBoxValabilitate.Left = 6 * Dimensiune_X;
            lblBoxValabilitate.Top = 5 * Dimensiune_Y;
            lblBoxValabilitate.ForeColor = Color.DarkCyan;
            lblBoxValabilitate.TextAlign = ContentAlignment.MiddleRight;
            this.Controls.Add(lblBoxValabilitate);

            lblBoxDetinator = new Label();
            lblBoxDetinator.Width = Latime;
            lblBoxDetinator.Text = "Detinator";
            lblBoxDetinator.Left = 6 * Dimensiune_X;
            lblBoxDetinator.Top = 6 * Dimensiune_Y;
            lblBoxDetinator.ForeColor = Color.DarkCyan;
            lblBoxDetinator.TextAlign = ContentAlignment.MiddleRight;
            this.Controls.Add(lblBoxDetinator);

            BtnAdauga = new Button();
            BtnAdauga.Width = Latime;
            BtnAdauga.Text = "Adauga";
            BtnAdauga.Top = 7 * Dimensiune_Y;
            BtnAdauga.Left = 7 * Dimensiune_X;
            BtnAdauga.Click += new EventHandler(this.GreetingBtn_Click);
            this.Controls.Add(BtnAdauga);
            BtnAdauga.Click += BtnAdauga_Click;

            BtnRefresh = new Button();
            BtnRefresh.Text = "Refresh";
            BtnRefresh.Top = 8 * Dimensiune_Y;
            BtnRefresh.Left = 7 * Dimensiune_X;
            BtnRefresh.Click += new EventHandler(this.Form1_Load);
            this.Controls.Add(BtnRefresh);
            BtnRefresh.Click += BtnRefresh_Click;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AfiseazaCarti();
        }

        private void AfiseazaCarti()
        {
            Carte[] carti = adminCarti.GetCarti(out int nrCarti);

            lblsTitlu = new Label[nrCarti];
            lblsAutor = new Label[nrCarti];
            lblsAnPublicatie = new Label[nrCarti];
            lblsSubiectLiterar = new Label[nrCarti];
            lblsValabilitate = new Label[nrCarti];
            lblsDetinator = new Label[nrCarti];

            int i = 0;
            foreach (Carte carte in carti)
            {

                if (i >= nrCarti)
                {
                    break;
                }
                //adaugare control de tip Label pentru numele studentilor;
                lblsTitlu[i] = new Label();
                lblsTitlu[i].Width = Latime;
                lblsTitlu[i].Text = carte.Titlu;
                lblsTitlu[i].Left = 0;
                lblsTitlu[i].Top = (i + 1) * Dimensiune_Y;
                this.Controls.Add(lblsTitlu[i]);

                //adaugare control de tip Label pentru prenumele studentilor
                lblsAutor[i] = new Label();
                lblsAutor[i].Width = Latime;
                lblsAutor[i].Text = carte.Autor;
                lblsAutor[i].Left = Dimensiune_X;
                lblsAutor[i].Top = (i + 1) * Dimensiune_Y;
                this.Controls.Add(lblsAutor[i]);

                lblsAnPublicatie[i] = new Label();
                lblsAnPublicatie[i].Width = Latime;
                lblsAnPublicatie[i].Text = carte.AnPublicatie.ToString();
                lblsAnPublicatie[i].Left = 2 * Dimensiune_X;
                lblsAnPublicatie[i].Top = (i + 1) * Dimensiune_Y;
                this.Controls.Add(lblsAnPublicatie[i]);

                lblsSubiectLiterar[i] = new Label();
                lblsSubiectLiterar[i].Width = Latime;
                lblsSubiectLiterar[i].Text = carte.SubiectLiterar;
                lblsSubiectLiterar[i].Left = 3 * Dimensiune_X;
                lblsSubiectLiterar[i].Top = (i + 1) * Dimensiune_Y;
                this.Controls.Add(lblsSubiectLiterar[i]);

                lblsValabilitate[i] = new Label();
                lblsValabilitate[i].Width = Latime;
                lblsValabilitate[i].Text = carte.Valabilitate.ToString();
                lblsValabilitate[i].Left = 4 * Dimensiune_X;
                lblsValabilitate[i].Top = (i + 1) * Dimensiune_Y;
                this.Controls.Add(lblsValabilitate[i]);

                lblsDetinator[i] = new Label();
                lblsDetinator[i].Width = Latime;
                lblsDetinator[i].Text = carte.Detinator;
                lblsDetinator[i].Left = 5 * Dimensiune_X;
                lblsDetinator[i].Top = (i + 1) * Dimensiune_Y;
                this.Controls.Add(lblsDetinator[i]);

                i++;
            }
        }

        void GreetingBtn_Click(Object sender, EventArgs e)
        {
            AdaugaCarti();
        }

        private void AdaugaCarti()
        {
            bool okTitlu = false;
            bool okAutor = false;
            bool okAnPublicatie = false;
            bool okSubiectLiterar = false;
            bool okValabilitate = false;
            bool okDetinator = false;


            if (boxTitlu.Text.Trim().Length > 0 && boxTitlu.Text.Trim().Length < 20)
            {
                lblBoxTitlu.ForeColor = Color.DarkGreen;
                okTitlu = true;
            }
            else
            {
                lblBoxTitlu.ForeColor = Color.Red;
            }

            if (boxAutor.Text.Trim().Length > 0 && boxAutor.Text.Trim().Length < 20)
            {
                lblBoxAutor.ForeColor = Color.DarkGreen;
                okAutor = true;
            }
            else
            {
                lblBoxAutor.ForeColor = Color.Red;
            }

            int number;
            if (boxAnPublicatie.Text.Trim().Length > 0 && int.TryParse(boxAnPublicatie.Text, out number))
            {
                lblBoxAnPublicatie.ForeColor = Color.DarkGreen;
                okAnPublicatie = true;
            }
            else
            {
                lblBoxAnPublicatie.ForeColor = Color.Red;
            }

            if (boxSubiectLiterar.Text.Trim().Length > 0 && boxSubiectLiterar.Text.Trim().Length < 20)
            {
                lblBoxSubiectLiterar.ForeColor = Color.DarkGreen;
                okSubiectLiterar = true;
            }
            else
            {
                lblBoxSubiectLiterar.ForeColor = Color.Red;
            }

            bool v = false;
            if (RbtValabilitate0.Checked)
            {
                v = false;
                okValabilitate = true;
            }
            if(RbtValabilitate1.Checked)
            {
                v = true;
                okValabilitate = true;
            }

            if (boxDetinator.Text.Trim().Length > 0 && boxDetinator.Text.Trim().Length < 20)
            {
                lblBoxDetinator.ForeColor = Color.DarkGreen;
                okDetinator = true;
            }
            else
            {
                lblBoxDetinator.ForeColor = Color.Red;
            }

            if (okTitlu && okAutor && okAnPublicatie && okSubiectLiterar && okValabilitate && okDetinator)
            {
                Carte carte = new Carte(boxTitlu.Text, boxAutor.Text, Convert.ToInt32(boxAnPublicatie.Text), boxSubiectLiterar.Text, v, boxDetinator.Text);
                //carte.SetNote(boxNote.Text);
                adminCarti.AddCarte(carte);
            }
            boxTitlu.Text = string.Empty;
            boxAutor.Text = string.Empty;
            boxAnPublicatie.Text = string.Empty;
            boxSubiectLiterar.Text = string.Empty;
            RbtValabilitate0.Checked = RbtValabilitate1.Checked = false;
            boxDetinator.Text = string.Empty;
            RbtValabilitate0.Checked = true;
            RbtValabilitate1.Checked = false;
            lblBoxTitlu.ForeColor = Color.DarkCyan;
            lblBoxAutor.ForeColor = Color.DarkCyan;
            lblBoxAnPublicatie.ForeColor = Color.DarkCyan;
            lblBoxSubiectLiterar.ForeColor = Color.DarkCyan;
            lblBoxValabilitate.ForeColor = Color.DarkCyan;
            lblBoxDetinator.ForeColor = Color.DarkCyan;


        }
        private void BtnAdauga_Click(object sender, EventArgs e)
        {
            AdaugaCarti();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            AfiseazaCarti();
        }
    }
}
