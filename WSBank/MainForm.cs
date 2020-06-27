using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSBank
{
    public partial class MainForm : Form
    {
        WSDB db;
        WSUser user;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            db = new WSDB("wsroot", "wstoor", "localhost", "wsbank");
            if (!db.connect())
            {
                MessageBox.Show("Połączenie z bazą danych nieudane!");
                Environment.Exit(0);
            }
            
        }

        private void SigninBtn_Click(object sender, EventArgs e)
        {
            user = WSAPI.loginUser(db, loginTxt.Text, passwordTxt.Text);
            if (user is null)
            {
                MessageBox.Show("Logowanie nieudane! Sprawdź wpisane dane!");
            }
            else
            {
                setUpPanel();
                loginGroup.Enabled = false;
                registerGroup.Enabled = false;
            }
        }
        void setUpPanel()
        {
            fullnameLbl.Text = "Witaj " + user.getFullName() + "!";
            balanceLbl.Text = WSAPI.getBalance(db,user.getUserId()).ToString()+"$";
            userpanelGroup.Visible = true;
        }

        private void SignoutButton_Click(object sender, EventArgs e)
        {
            userpanelGroup.Visible = false;
            loginGroup.Enabled = true;
            registerGroup.Enabled = true;
            user = null;
            loginTxt.Text = "";
            passwordTxt.Text = "";
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć konto w WSBanku ?", "Uwaga!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (WSAPI.deleteUser(db, user.getUserId()))
                {
                    userpanelGroup.Visible = false;
                    loginGroup.Enabled = true;
                    registerGroup.Enabled = true;
                    user = null;
                    loginTxt.Text = "";
                    passwordTxt.Text = "";
                    MessageBox.Show("Usunięto konto pomyślnie!");
                }
                else
                {
                    MessageBox.Show("Błąd przy usuwaniu konta!");
                }
            }
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            string fname = rFnameTxt.Text;
            string lname = rLnameTxt.Text;
            string login = rLoginTxt.Text;
            string password1 = rPassword1Txt.Text;
            string password2 = rPassword2Txt.Text;
            string balance = rBalanceTxt.Text;
            if (fname.Length<3 || lname.Length<3)
            {
                MessageBox.Show("Podane imię lub nazwisko jest niepoprawne!");
                return;
            }
            if (login.Length<5)
            {
                MessageBox.Show("Login musi mieć przynajmniej 5 znaków!");
                return;
            }
            if (!WSAPI.loginAvailable(db,login))
            {
                MessageBox.Show("Podana nazwa użytkownika jest zajęta!");
                return;
            }
            if (password1.Length < 8 || password2.Length<8)
            {
                MessageBox.Show("Hasło musi mieć przynajmniej 8 znaków!");
                return;
            }
            if (password1!=password2)
            {
                MessageBox.Show("Podane hasła nie są równe!");
                return;
            }
            int b;
            if (!int.TryParse(balance, out b))
            {
                MessageBox.Show("Wpłata niepoprawna!");
                return;
            }
            if (b<0)
            {
                MessageBox.Show("Wpłata niepoprawna!");
                return;
            }
            if (WSAPI.registerUser(db,fname,lname,login,password1,b))
            {
                MessageBox.Show("Zarejestrowano pomyślnie! Możesz się teraz zalogować do swojego konta("+login+")!");
                loginTxt.Text = login;
                passwordTxt.Text = "";
                return;
            }
            else
            {
                MessageBox.Show("Błąd przy rejestracji!");
                return;
            }
        }

        private void UserpanelGroup_Enter(object sender, EventArgs e)
        {

        }

        private void TransferBtn_Click(object sender, EventArgs e)
        {
            string reclogin = recTxt.Text;
            string amount = amountTxt.Text;
            int a;
            if (!int.TryParse(amount, out a))
            {
                MessageBox.Show("Kwota niepoprawna!");
                return;
            }
            if (a < 1)
            {
                MessageBox.Show("Kwota musi być większa od 0!");
                return;
            }
            if (a>WSAPI.getBalance(db,user.getUserId()))
            {
                MessageBox.Show("Kwota nie może przekraczać dostępnego salda!");
                return;
            }
            if (WSAPI.loginAvailable(db,reclogin))
            {
                MessageBox.Show("Konto odbiorcy nie istnieje!");
                return;
            }
            if (WSAPI.makeTransaction(db,user.getUserId(), reclogin,a))
            {
                MessageBox.Show("Wykonano przelew!");
                setUpPanel();
                return;
            }
            else
            {
                MessageBox.Show("Błąd przy wykonaniu przelewu!");
                return;
            }
        }
    }
}
