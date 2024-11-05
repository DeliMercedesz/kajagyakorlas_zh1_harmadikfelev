using kajagyakorlas.Models;
using System.Xml.Linq;

namespace kajagyakorlas
{


    public partial class Form1 : Form
    {
        ReceptContext _context = new ReceptContext();
        public Form1()
        {
            InitializeComponent();
            FogasokLoad();
            NyersenyagLoad();
            loadReceptek();
        }


        private void FogasokLoad()  //fogások betöltése a listboxba
        {
            var fogasok_lista = (from r in _context.Fogasok
                                 where r.FogasNev.Contains(fogastxt.Text)
                                 select r).ToList();

            fogasokBindingSource.DataSource = fogasok_lista;



        }

        private void NyersenyagLoad() //nyersanyag betöltése a listboxba
        {
            var Nyersanyagok_lista = (from ny in _context.Nyersanyagok
                                      where ny.NyersanyagNev.Contains(Nyersanyagtxt.Text)
                                      select ny).ToList();

            nyersanyagokBindingSource.DataSource = Nyersanyagok_lista;

        }


        //EZ A KETTŐ A SZŰRÉS
        private void fogastxt_TextChanged(object sender, EventArgs e)
        {
            FogasokLoad();
        }

        private void Nyersanyagtxt_TextChanged(object sender, EventArgs e)
        {
            NyersenyagLoad();
        }



        private void Nyersanyaglb_SelectedIndexChanged(object sender, EventArgs e)
        {
            var kiválasztottNyersanyag = (Nyersanyagok)Nyersanyaglb.SelectedItem; //ez adja meg a listboxban kiválasztott elemet


            if (kiválasztottNyersanyag.MennyisegiEgysegId == null) //meglesem h van-e egyáltalán ID, ha nincs --> nincs név se
            {
                labelmennyegys.Text = "Nincs mennyiségegység név";
            }
            else
            {
                var adottmennyisegegyseg = (from m in _context.MennyisegiEgysegek
                                            where m.MennyisegiEgysegId == kiválasztottNyersanyag.MennyisegiEgysegId
                                            select m).FirstOrDefault();

                labelmennyegys.Text = adottmennyisegegyseg.EgysegNev;
            }

        }

        private void loadReceptek() //itt töltjük be a datagridview-t --> külön osztályt használunk mert több tábla kell
        {
            var kivalasztottfogas = (Fogasok)fogaslb.SelectedItem;
            var recept_lista = (from x in _context.Receptek
                                where x.FogasId == kivalasztottfogas.FogasId
                                select new Hozzávaló
                                {
                                    ReceptID = x.ReceptId,
                                    FogasID = x.FogasId,
                                    NyersanyagNev = x.Nyersanyag.NyersanyagNev,
                                    Mennyiseg_4fo = x.Mennyiseg4fo,
                                    EgysegNev = x.Nyersanyag.MennyisegiEgyseg.EgysegNev,
                                    Ár = x.Mennyiseg4fo * (double?)x.Nyersanyag.Egysegar //át kell konvertálni double-ra mert a másik az

                                }).ToList();

            hozzávalóBindingSource.DataSource = recept_lista;
            dataGridView1.DataSource = hozzávalóBindingSource.DataSource;
        }

        private void fogaslb_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadReceptek();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Receptek r = new Receptek();
            r.NyersanyagId = ((Nyersanyagok)Nyersanyaglb.SelectedItem).NyersanyagId;
            r.FogasId = ((Fogasok)fogaslb.SelectedItem).FogasId;
            double m;
            if (!double.TryParse(mennyisegtxt.Text, out m)) return;
            r.Mennyiseg4fo = m;
            _context.Receptek.Add(r);
            _context.SaveChanges();
            loadReceptek(); //Az középső rácsot kell újratölteni
        }

        private void remove_Click(object sender, EventArgs e)
        {
            var törlendő = dataGridView1.SelectedRows[0].DataBoundItem as Hozzávaló;

            var törlendők = (from x in _context.Receptek
                             where x.ReceptId == törlendő!.ReceptID
                             select x).FirstOrDefault();

            _context.Receptek.Remove(törlendők);
            _context.SaveChanges();
            loadReceptek();
        }

        private void button1_Click(object sender, EventArgs e)  //Nyersanyag hozzáadása
        {
            ujNyersanyag ujnyers = new ujNyersanyag();

            if (ujnyers.ShowDialog() == DialogResult.OK)
            {
                Nyersanyagok ujnyersanyag = new Nyersanyagok();
                ujnyersanyag.NyersanyagNev = ujnyers.Nevtxt.Text;
                ujnyersanyag.Egysegar = int.Parse(ujnyers.Egysegartxt.Text);

                _context.Nyersanyagok.Add(ujnyersanyag);
                _context.SaveChanges();
                NyersenyagLoad();
            }
            else
            {
                MessageBox.Show("Nem OK-al zárult");
            }
        }

        private void xml_Click(object sender, EventArgs e) //xml fájl írás
        {
            var nyersanagokxml =(from ny in _context.Nyersanyagok
                                 select ny).ToList();
            XDocument xdoc = new XDocument();
            XDeclaration xdecl = new XDeclaration("1.0", "utf-8", "yes");
            xdoc.Declaration = xdecl;

            // Győkérelem létrehozása
            XElement root = new XElement("Nyersanyagok");
            xdoc.Add(root);

            foreach (var nyers in nyersanagokxml)
            {
                if(nyers.NyersanyagNev == null)
                {
                    nyers.NyersanyagNev = "";
                }
                XElement node = new XElement("Nyersanyagok",
                new XAttribute("NyersanyagID", nyers.NyersanyagId),
                new XAttribute("Nev", nyers.NyersanyagNev));

                root.Add(node);
            }

            MessageBox.Show(xdoc.ToString());
        }
    }

    public class Hozzávaló
    {
        public int ReceptID { get; set; }
        public int? FogasID { get; set; }
        public string NyersanyagNev { get; set; }
        public double? Mennyiseg_4fo { get; set; }
        public string EgysegNev { get; set; }
        public double? Ár { get; set; }
    }
  
}
