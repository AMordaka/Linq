using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Linq
{
    public partial class Form1 : Form
    {
        private String textPrice;
        private String text;
        private XmlReader reader = new XmlReader();

        public Form1()
        {
            InitializeComponent();
        }


        private void buttonFindById_Click(object sender, EventArgs e)
        {
            var item = reader.findById(text);
            labelResult.Text = "";
            printItem(item);
        }

        private void buttonFindByYear_Click(object sender, EventArgs e)
        {
            var items = reader.findByYear(text);
            checkResult(items);
        }

        private void buttonFindByCountry_Click(object sender, EventArgs e)
        {
            var items = reader.findByCountry(text);
            checkResult(items);
        }

        private void buttonFindByCountryPrice_Click(object sender, EventArgs e)
        {
            double price;
            bool isValid = double.TryParse(textPrice, out price);
            if (isValid)
            {
                var items = reader.findByCountryAndPrice(text, price);
                checkResult(items);
            }
            else
            {
                printError();
            }
        }

        void printError()
        {
            labelResult.Text = "Nieporawne dane lub brak wyników";
        }

        void checkResult(IEnumerable<XElement> items)
        {
            labelResult.Text = "";
            if (items.Any())
            {
                foreach (XElement item in items)
                {
                    printItem(item);
                }
            }
            else
            {
                printError();
            }
        }

        void printItem(XElement item)
        {
            if (item != null)
            {
                labelResult.Text += ("Autor: " + item.Element("ARTIST").Value + "\n");
                labelResult.Text += ("Tytuł: " + item.Element("TITLE").Value + "\n");
                labelResult.Text += ("Zespoł: " + item.Element("COMPANY").Value + "\n");
                labelResult.Text += ("Kraj: " + item.Element("COUNTRY").Value + "\n");
                labelResult.Text += ("Rok: " + item.Element("YEAR").Value + "\n");
                labelResult.Text += ("Cena: " + item.Element("PRICE").Value + "\n\n");
            }
            else
            {
                printError();
            }
        }


        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            text = textBoxId.Text;
        }

        private void textBoxYear_TextChanged(object sender, EventArgs e)
        {
            text = textBoxYear.Text;
        }

        private void textBoxCountry_TextChanged(object sender, EventArgs e)
        {
            text = textBoxCountry.Text;
        }

        private void textBoxCountryPrice_TextChanged(object sender, EventArgs e)
        {
            text = textBoxCountryPrice.Text;
        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            textPrice = textBoxPrice.Text;
        }
    }
}
