using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class FormCalcu : Form
    {
        double primero;
        double segundo;
        string operador;
        string colorActivo = "#6FEE6D";
        string colorOriginal = "#B9D1EA";
        bool activeOperator = false;
        ClassSuma objSuma = new ClassSuma();
        ClassResta objResta = new ClassResta();
        ClassProd objProd = new ClassProd();
        ClassDiv objDiv = new ClassDiv();
        public FormCalcu()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(FormCalcu_KeyDown);
        }

        //MÉTODO PARA CONTROL DE CAMBIO DE COLOR DE LOS OPERADORES
        private void btnColorControl()
        {
            if (!(Double.IsNaN(primero)) | activeOperator == true)
            {
                switch (operador)
                {
                    case "+":
                        btnSuma.BackColor = ColorTranslator.FromHtml(colorActivo);
                        btnResta.BackColor = ColorTranslator.FromHtml(colorOriginal);
                        btnDiv.BackColor = ColorTranslator.FromHtml(colorOriginal);
                        btnMult.BackColor = ColorTranslator.FromHtml(colorOriginal);
                        break;
                    case "-":
                        btnSuma.BackColor = ColorTranslator.FromHtml(colorOriginal);
                        btnResta.BackColor = ColorTranslator.FromHtml(colorActivo);
                        btnDiv.BackColor = ColorTranslator.FromHtml(colorOriginal);
                        btnMult.BackColor = ColorTranslator.FromHtml(colorOriginal);
                        break;
                    case "*":
                        btnSuma.BackColor = ColorTranslator.FromHtml(colorOriginal);
                        btnResta.BackColor = ColorTranslator.FromHtml(colorOriginal);
                        btnDiv.BackColor = ColorTranslator.FromHtml(colorOriginal);
                        btnMult.BackColor = ColorTranslator.FromHtml(colorActivo);
                        break;
                    case "/":
                        btnSuma.BackColor = ColorTranslator.FromHtml(colorOriginal);
                        btnResta.BackColor = ColorTranslator.FromHtml(colorOriginal);
                        btnDiv.BackColor = ColorTranslator.FromHtml(colorActivo);
                        btnMult.BackColor = ColorTranslator.FromHtml(colorOriginal);
                        break;
                    case "C":
                        btnSuma.BackColor = ColorTranslator.FromHtml(colorOriginal);
                        btnResta.BackColor = ColorTranslator.FromHtml(colorOriginal);
                        btnDiv.BackColor = ColorTranslator.FromHtml(colorOriginal);
                        btnMult.BackColor = ColorTranslator.FromHtml(colorOriginal);
                        break;
                    case "=":
                        btnSuma.BackColor = ColorTranslator.FromHtml(colorOriginal);
                        btnResta.BackColor = ColorTranslator.FromHtml(colorOriginal);
                        btnDiv.BackColor = ColorTranslator.FromHtml(colorOriginal);
                        btnMult.BackColor = ColorTranslator.FromHtml(colorOriginal);
                        break;
                }
            }
            else
            {
                screen.Clear();
            }
        }
        
        //BOTONES DE NÚMEROS
        private void BtnN0_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + "0";
            focusLabel.Focus();
        }
        private void BtnN1_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + "1";
            focusLabel.Focus();
        }
        private void BtnN2_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + "2";
            focusLabel.Focus();
        }
        private void BtnN3_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + "3";
            focusLabel.Focus();
        }
        private void BtnN4_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + "4";
            focusLabel.Focus();
        }
        private void BtnN5_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + "5";
            focusLabel.Focus();
        }
        private void BtnN6_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + "6";
            focusLabel.Focus();
        }
        private void BtnN7_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + "7";
            focusLabel.Focus();
        }
        private void BtnN8_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + "8";
            focusLabel.Focus();
        }
        private void BtnN9_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + "9";
            focusLabel.Focus();
        }
        private void BtnPto_Click(object sender, EventArgs e)
        {
            if (!(screen.Text.Contains(",")))
            {
                screen.Text = screen.Text + ",";
            }
            focusLabel.Focus();
        }

        //BOTONES DE OPERACIONES
        private void BtnSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            activeOperator = true;
            btnColorControl();
            if (screen.Text.Any(char.IsDigit))
            {
                primero = double.Parse(screen.Text);
                screen.Clear();
            }
            focusLabel.Focus();
        }
        private void BtnResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            activeOperator = true;
            btnColorControl();
            if (screen.Text.Any(char.IsDigit))
            {
                primero = double.Parse(screen.Text);
                screen.Clear();
            }
            focusLabel.Focus();
        }
        private void BtnMult_Click(object sender, EventArgs e)
        {
            operador = "*";
            activeOperator = true;
            btnColorControl();
            if (screen.Text.Any(char.IsDigit))
            {
                primero = double.Parse(screen.Text);
                screen.Clear();
            }
            focusLabel.Focus();
        }
        private void BtnDiv_Click(object sender, EventArgs e)
        {
            operador = "/";
            activeOperator = true;
            btnColorControl();
            if (screen.Text.Any(char.IsDigit))
            {
                primero = double.Parse(screen.Text);
                screen.Clear();
            }
            focusLabel.Focus();
        }
        //BOTONES DE FUNCIONES ESPECIALES
        private void BtnClear_Click(object sender, EventArgs e)
        {
            operador = "C";
            btnColorControl();
            screen.Clear();
            activeOperator = false;
            focusLabel.Focus();
        }
        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            if (screen.Text.Length > 0)
            {
                if (screen.Text.Length == 1)
                {
                    screen.Text = "";
                }
                else
                {
                    screen.Text = screen.Text.Substring(0, screen.Text.Length - 1);
                }
            }
            else
            {
                screen.Clear();
            }
            focusLabel.Focus();
        }
        private void BtnIgual_Click(object sender, EventArgs e)
        {
            double resultado;
            
            if (!(Double.IsNaN(primero)) && screen.Text.Any(char.IsDigit))
            {
                segundo = double.Parse(screen.Text);
                switch (operador)
                {
                    case "+":
                        resultado = objSuma.Sumar((primero), (segundo));
                        screen.Text = resultado.ToString();
                        operador = "=";
                        break;
                    case "-":
                        resultado = objResta.Restar((primero), (segundo));
                        screen.Text = resultado.ToString();
                        operador = "=";
                        break;
                    case "*":
                        resultado = objProd.Multiplicar((primero), (segundo));
                        screen.Text = resultado.ToString();
                        operador = "=";
                        break;
                    case "/":
                        resultado = objDiv.Dividir((primero), (segundo));
                        screen.Text = resultado.ToString();
                        operador = "=";
                        break;
                }
                btnColorControl();
            }
            else
            {
                operador = "=";
                btnColorControl();
                screen.Clear();
            }
            activeOperator = false;
            btnColorControl();
            focusLabel.Focus();
        }

        //EVENTO PARA CONTROLAR EL PROGRAMA DESDE EL TECLADO
        private void FormCalcu_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                //TECLAS NUMÉRICAS
                case Keys.NumPad1:
                    e.Handled = true;
                    BtnN1_Click(new object(), new EventArgs());
                    break;
                case Keys.NumPad2:
                    e.Handled = true;
                    BtnN2_Click(new object(), new EventArgs());
                    break;
                case Keys.NumPad3:
                    e.Handled = true;
                    BtnN3_Click(new object(), new EventArgs());
                    break;
                case Keys.NumPad4:
                    e.Handled = true;
                    BtnN4_Click(new object(), new EventArgs());
                    break;
                case Keys.NumPad5:
                    e.Handled = true;
                    BtnN5_Click(new object(), new EventArgs());
                    break;
                case Keys.NumPad6:
                    e.Handled = true;
                    BtnN6_Click(new object(), new EventArgs());
                    break;
                case Keys.NumPad7:
                    e.Handled = true;
                    BtnN7_Click(new object(), new EventArgs());
                    break;
                case Keys.NumPad8:
                    e.Handled = true;
                    BtnN8_Click(new object(), new EventArgs());
                    break;
                case Keys.NumPad9:
                    e.Handled = true;
                    BtnN9_Click(new object(), new EventArgs());
                    break;
                case Keys.NumPad0:
                    e.Handled = true;
                    BtnN0_Click(new object(), new EventArgs());
                    break;
                //TECLAS DE OPERADORES Y ESPECIALES
                case Keys.Decimal:
                    e.Handled = true;
                    BtnPto_Click(new object(), new EventArgs());
                    break;
                case Keys.Add:
                    e.Handled = true;
                    BtnSuma_Click(new object(), new EventArgs());
                    break;
                case Keys.Subtract:
                    e.Handled = true;
                    BtnResta_Click(new object(), new EventArgs());
                    break;
                case Keys.Multiply:
                    e.Handled = true;
                    BtnMult_Click(new object(), new EventArgs());
                    break;
                case Keys.Divide:
                    e.Handled = true;
                    BtnDiv_Click(new object(), new EventArgs());
                    break;
                case Keys.Back:
                    e.Handled = true;
                    BtnBorrar_Click(new object(), new EventArgs());
                    break;
                case Keys.Enter:
                    e.Handled = true;
                    BtnIgual_Click(new object(), new EventArgs());
                    break;
            }
        }
    }
}