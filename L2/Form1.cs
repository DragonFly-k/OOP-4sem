using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Text.Json;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Xml.Serialization;
using System.Text.RegularExpressions;
using L2.Memento;

namespace L2
{
    
    public partial class Form1 : Form
    {
        public List<Account> accounts;
        NHist hist =new NHist();
        private IOrderedEnumerable<Account> account;
        public Form1()
        {
            InitializeComponent();
            Singleton.GetSettings(this);
            accounts = new List<Account>();
            type.KeyPress += (sender, e) => e.Handled = true;
            Timer Timer = new Timer() { Interval=1000};
            Timer.Start();
            Timer.Tick += Tick;
        }
        private void Tick(object sender, EventArgs e)
        {
            toolStripLabel1.Text = DateTime.Now.ToString();
                
        }

        private void balance_Scroll(object sender, EventArgs e)
        {
            label3.Text = $"Баланс: {(sender as TrackBar).Value}";
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                hist.Form.Push(SaveData());
                var account = new Account(int.Parse(num.Text), Account.Types.open, balance.Value, opendate.Value, sms.Checked, new Account.Owner()
                {
                    Birthdate = opendate.Value,
                    Name = name.Text,
                    Passport = passport.Text,
                });

                if (!sms.Checked)
                    account.Type = Account.Types.closed;
                if (type.Text == "Закрытый")
                {
                    account.Type = Account.Types.closed;
                }

                ValidationContext context = new ValidationContext(account, null, null);
                IList<ValidationResult> errors = new List<ValidationResult>();
                ValidationContext context2 = new ValidationContext(account.owner, null, null);

                if (!Validator.TryValidateObject(account, context, errors, true) || !Validator.TryValidateObject(account.owner, context2, errors, true))
                {
                    foreach (ValidationResult result in errors)
                        MessageBox.Show(result.ErrorMessage);
                }
                else
                {
                    MessageBox.Show("Одобрен!");
                    listBox1.Items.Add(account);
                    accounts.Add(account);
                }
            }
            catch
            {
                if (balance.Value == 0 && num.Text == "" && type.Text == "" && name.Text == "")
                {
                    MessageBox.Show("!!! Рандомное заполнение !!!");
                }
                else
                {
                    MessageBox.Show("!!! НЕ корректно запоненная форма !!!");
                    this.очистить_Click(sender, e);
                }                    
            }
            if (balance.Value == 0 && num.Text == "" && type.Text == "" && name.Text == "")
            {

                var direct = new Builder();
                var builder = new AccountB();
                direct.Construct(builder, builder);
                listBox1.Items.Add(builder.GetResult());
                accounts.Add(builder.GetResult());

                Account acc = new Account();
                acc.owner = acc.CreateOwner() as L2.Account.Owner;
                listBox1.Items.Add(acc);

                Account decorator = new Decorator.Decorator(accounts[0]);
                listBox1.Items.Add(decorator);


            }
        }
        public Saf SaveData()
        {
            return new Saf(ref accounts);
        }
        public void RestoreData(Saf data)
        {
            accounts= data.accounts;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        { 
            XmlSerializer serializer = new XmlSerializer(typeof(List<Account>));
            using (FileStream stream = new FileStream("file.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(stream, accounts);
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Account>));
            using (FileStream stream = new FileStream("file.xml", FileMode.Open))
            {
                accounts = serializer.Deserialize(stream) as List<Account>;
                listBox1.Items.Clear();
                foreach (var t in accounts)
                {
                    listBox1.Items.Add(t);
                }
            }
        }
        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Search = new Form2(accounts);
            Search.ShowDialog();
        }

        private void поНомеруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            accounts = accounts.OrderBy(x => x.num).ToList();
            foreach (var ac in accounts)
            {
                listBox1.Items.Add(ac);
            }
            XmlSerializer serializer = new XmlSerializer(typeof(List<Account>));
            using (FileStream stream = new FileStream("Sort.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(stream, accounts);
            }
        }

        private void поГодуОткрытияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            accounts = accounts.OrderBy(x => x.OpeningDate).ToList();
            foreach (var ac in accounts)
            {
                listBox1.Items.Add(ac);
            }

            XmlSerializer serializer = new XmlSerializer(typeof(List<Account>));
            using (FileStream stream = new FileStream("Sort.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(stream, accounts);
            }
        }

        private void типВкладаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            accounts = accounts.OrderBy(x => x.Type).ToList();
            foreach (var ac in accounts)
            {
                listBox1.Items.Add(ac);
            }

            XmlSerializer serializer = new XmlSerializer(typeof(List<Account>));
            using (FileStream stream = new FileStream("Sort.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(stream, accounts);
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bank version: 1.0.0\nDeveloper: SED");
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.Match(e.KeyChar.ToString(), @"[а-яА-Я]|[a-zA-Z]").Success)
            {
                e.Handled = true;
            }
        }

        private void num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.Match(e.KeyChar.ToString(), @"[0-9]").Success)
            {
                e.Handled = true;
            }
        }

        private void очистить_Click(object sender, EventArgs e)
        {
            balance.Value = 0;
            num.Text = "";
            type.Text = "";
            name.Text = "";
            passport.Text = "";
            sms.Checked = false;
            label3.Text = $"Баланс ";
        }

        private void поиск_Click(object sender, EventArgs e)
        {
            var Search = new Form2(accounts);
            Search.ShowDialog();
        }

        private void сортировка_Click(object sender, EventArgs e)
        {
            hist.Form.Push(SaveData());
            listBox1.Items.Clear();
            accounts = accounts.OrderBy(x => x.num).ToList();
            foreach (var ac in accounts)
            {
                listBox1.Items.Add(ac);
            }
            XmlSerializer serializer = new XmlSerializer(typeof(List<Account>));
            using (FileStream stream = new FileStream("Sort.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(stream, accounts);
            }
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = true;
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = false;
        }
        private void clone_Click(object sender, EventArgs e)
        {
            Account account = accounts[0].Clone() as Account;
            listBox1.Items.Add(account);
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                listBox1.Refresh();
                RestoreData(hist.Form.Pop());
                foreach (Account account in accounts)
                {
                    listBox1.Items.Add(account);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }
    }
}