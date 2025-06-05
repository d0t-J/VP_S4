using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class CartItemControl : UserControl
    {
        public CartItemControl()
        {
            InitializeComponent();

            btn_Add.Click += btn_Add_Click;
            btn_Remove.Click += btn_Remove_Click;
            btn_DeleteAll.Click += btn_DeleteAll_Click;

            Label_Qty.Text = _quantityInCart.ToString();
        }
        public int MedicineId { get; set; }
        public string MedicineName
        {
            get => Label_Name.Text;
            set => Label_Name.Text = value;
        }

        public string MedicineCategory
        {
            get => Label_Category.Text;
            set => Label_Category.Text = value;
        }

        public decimal UnitPrice { get; set; }

        public int CurrentStock { get; set; }

        private int _quantityInCart = 1;
        public int QuantityInCart
        {
            get => _quantityInCart;
            set
            {
                int newQty = Math.Max(1, value);
                if (newQty > CurrentStock)
                {
                    newQty = CurrentStock;
                }
                _quantityInCart = newQty;
                Label_Qty.Text = _quantityInCart.ToString();
                UpdateSubtotalLabel();
                QuantityChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        public event EventHandler QuantityChanged;
        public event EventHandler ItemRemoved;

        private void UpdateSubtotalLabel()
        {
            // If you included a label (Label_Subtotal) in your design, uncomment this:
            //
            decimal subtotal = UnitPrice * _quantityInCart;
            Label_Subtotal.Text = subtotal.ToString("C2");
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (_quantityInCart < CurrentStock)
            {
                QuantityInCart = _quantityInCart + 1;
            }
            else
            {
                MessageBox.Show("Cannot exceed available stock");
                btn_Add.Enabled = false;
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (_quantityInCart > 1)
            {
                QuantityInCart = _quantityInCart - 1;
            }
            else
            {
                btn_Remove.Enabled = false;
            }
        }

        private void btn_DeleteAll_Click(object sender, EventArgs e)
        {
            ItemRemoved?.Invoke(this, EventArgs.Empty);
        }

        public void Initialize(int medId, string name, string category, decimal unitPrice, int stock, int initialQty = 1)
        {
            MedicineId = medId;
            MedicineName = name;
            MedicineCategory = category;
            UnitPrice = unitPrice;
            CurrentStock = stock;
            _quantityInCart = 1;
            QuantityInCart = initialQty;
        }
    }
}
