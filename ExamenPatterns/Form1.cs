using ExamenPatterns.AbstractFactory.Factory;
using ExamenPatterns.AbstractFactory.Product.AbstractProduct;
using ExamenPatterns.AbstractFactory.Product.AbstractProduct.Type;
using ExamenPatterns.AbstractFactory.Product.ConcreteProduct;
using ExamenPatterns.ChainOfResponsibility;
using ExamenPatterns.Observer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenPatterns
{
    public partial class Form1 : Form
    {
        CafeItaly cafeItaly;
        CafeReadHead cafeReadHead;
        AbstractPizza pizza;
        AbstractBarbecue barbecue;
        Market market;
        uint order;

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            toolStripStatusLabel2Date.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabel3Time.Text = DateTime.Now.ToLongTimeString();
            order = 1;
            market = new Market();
            cafeItaly = new CafeItaly(market);
            cafeReadHead = new CafeReadHead(market);
            cafeItaly.Successor = cafeReadHead;
            cafeReadHead.Successor = cafeItaly;
            // ChooseYourCafe
            comboBoxChooseYourCafe.Items.Add(cafeItaly.Name);
            comboBoxChooseYourCafe.Items.Add(cafeReadHead.Name);
            comboBoxChooseYourCafe.Text = comboBoxChooseYourCafe.Items[0].ToString();
            comboBoxChooseYourCafe.SelectedItem = comboBoxChooseYourCafe.Items[0].ToString();
            // price
            SetListBoxPrice();
            comboBoxSelectAMealForChange.Text = comboBoxSelectAMealForChange.Items[0].ToString();
            comboBoxSelectAMealForChange.SelectedItem = comboBoxSelectAMealForChange.Items[0].ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2Date.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabel3Time.Text = DateTime.Now.ToLongTimeString();
        }

        private void CheckSelectAMeal()
        {
            comboBoxSelectTypeOfMeal.Items.Clear();
            if (comboBoxSelectAMeal.Text == "Pizza")
            {
                SetVisible(true);
                if (comboBoxChooseYourCafe.Text == cafeItaly.Name)
                {
                    comboBoxSelectTypeOfMeal.Items.AddRange(cafeItaly.ListOfProducedPizzasByType.Select(a => a.ToString()).ToArray());
                }
                else
                    comboBoxSelectTypeOfMeal.Items.AddRange(cafeReadHead.ListOfProducedPizzasByType.Select(a => a.ToString()).ToArray());
            }
            else if(comboBoxSelectAMeal.Text == "Barbecue")
            {
                SetVisible(false);
                comboBoxSelectTypeOfMeal.Items.AddRange(cafeItaly.ListOfProducedBarbecueByTypeOfMeat.Select(a => a.ToString()).ToArray());
                comboBoxSelectTypeOfMeal.Items.AddRange(cafeReadHead.ListOfProducedBarbecueByTypeOfMeat.Select(a => a.ToString()).ToArray());
            }
            comboBoxSelectTypeOfMeal.Text = comboBoxSelectTypeOfMeal.Items[0].ToString();
            comboBoxSelectTypeOfMeal.SelectedItem = comboBoxSelectTypeOfMeal.Items[0].ToString();
        }
        private void SetVisible(bool f)
        {
            labelSelectComposition.Visible = f;
            comboBoxSelectComposition.Visible = f;
            labelIngredientsWeight.Visible = f;
            comboBoxIngredientsWeight.Visible = f;
            labelAddToMeal.Visible = f;
            comboBoxAddToMeal.Visible = f;
        }

        private void comboBoxSelectAMeal_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckSelectAMeal();
        }

        private void buttonAddToOrderList_Click(object sender, EventArgs e)
        {
            if (cafeItaly.IdOrder != order && cafeReadHead.IdOrder != order)
            {
                listBoxOrdersCheckList.Items.Clear();
                labelOrdersListCheck.Text = "Orders list";
            }
            PizzaType pizzaType = GetPizzaType(comboBoxSelectTypeOfMeal.SelectedItem.ToString());
            string composition = comboBoxSelectComposition.SelectedItem.ToString();
            double ingredientsWeight = Convert.ToDouble(comboBoxIngredientsWeight.SelectedItem.ToString());
            string typeOfMeal = comboBoxSelectTypeOfMeal.SelectedItem.ToString();
            string addToMeal = comboBoxAddToMeal.SelectedItem.ToString();

            if (comboBoxChooseYourCafe.SelectedItem.ToString() == cafeItaly.Name)
            {
                cafeItaly.IdOrder = order;
                if (comboBoxSelectAMeal.SelectedItem.ToString() == "Pizza")
                {
                    pizza = cafeItaly.CreatePizza (pizzaType, composition, ingredientsWeight, order, addToMeal);
                    if(pizza!=null)
                        listBoxOrdersCheckList.Items.Add(pizza.ToString());
                }
                else if (comboBoxSelectAMeal.SelectedItem.ToString() == "Barbecue")
                {
                    barbecue = cafeItaly.CreateBarbecue(typeOfMeal, order);
                    if (barbecue != null)
                        listBoxOrdersCheckList.Items.Add(barbecue.ToString());
                }
            }
            else if (comboBoxChooseYourCafe.SelectedItem.ToString() == cafeReadHead.Name)
            {
                cafeReadHead.IdOrder = order;
                if (comboBoxSelectAMeal.SelectedItem.ToString() == "Pizza")
                {
                    pizza = cafeReadHead.CreatePizza(pizzaType, composition, ingredientsWeight, order, addToMeal);
                    if (pizza != null)
                        listBoxOrdersCheckList.Items.Add(pizza.ToString());
                }
                else if (comboBoxSelectAMeal.SelectedItem.ToString() == "Barbecue")
                {
                    barbecue = cafeReadHead.CreateBarbecue(typeOfMeal, order);
                    if (barbecue != null)
                        listBoxOrdersCheckList.Items.Add(barbecue.ToString());
                }
            }
        }

        private PizzaType GetPizzaType(string type)
        {
            if (type == PizzaType.Closed.ToString())
                return PizzaType.Closed;
            return PizzaType.Open;
        }

        private void buttonGetCheck_Click(object sender, EventArgs e)
        {
            order++;
            listBoxOrdersCheckList.Items.Clear();
            labelOrdersListCheck.Text = "Your Check";
            decimal totalPrice = 0;
            if (cafeItaly.ListOrders.Count != 0)
            {
                totalPrice += cafeItaly.ListCheck.Sum();
                listBoxOrdersCheckList.Items.Add("\t\t"+cafeItaly.Name);
                for (int i = 0; i < cafeItaly.ListOrders.Count; i++)
                    listBoxOrdersCheckList.Items.Add(cafeItaly.ListOrders[i] + "=" + cafeItaly.ListCheck[i].ToString("f2") + "$");
            }
            if (cafeReadHead.ListOrders.Count != 0)
            {
                totalPrice += cafeReadHead.ListCheck.Sum();
                listBoxOrdersCheckList.Items.Add("\t\t" + cafeReadHead.Name);
                for (int i = 0; i < cafeReadHead.ListOrders.Count; i++)
                    listBoxOrdersCheckList.Items.Add(cafeReadHead.ListOrders[i] + "=" + cafeReadHead.ListCheck[i].ToString("f2") + "$");
            }
            listBoxOrdersCheckList.Items.Add("Total price: "+ totalPrice.ToString("f2") + "$");
            cafeItaly.ListCheck.Clear();
            cafeItaly.ListOrders.Clear();
            cafeReadHead.ListCheck.Clear();
            cafeReadHead.ListOrders.Clear();
        }

        private void comboBoxChooseYourCafe_SelectedIndexChanged(object sender, EventArgs e)
        {
            // SelectAMeal
            comboBoxSelectAMeal.Items.Clear();
            comboBoxSelectAMeal.Items.Add("Pizza");
            comboBoxSelectAMeal.Items.Add("Barbecue");
            comboBoxSelectAMeal.Text = comboBoxSelectAMeal.Items[0].ToString();
            comboBoxSelectAMeal.SelectedItem = comboBoxSelectAMeal.Items[0].ToString();
            // Select type of meal
            CheckSelectAMeal();
            comboBoxSelectComposition.Items.Clear();
            comboBoxIngredientsWeight.Items.Clear();
            comboBoxAddToMeal.Items.Clear();
            comboBoxAddToMeal.Items.Add("-");
            if (comboBoxChooseYourCafe.Text == cafeItaly.Name)
            {
                comboBoxSelectComposition.Items.AddRange(cafeItaly.ListOfProducedPizzasByCompositions.ToArray());
                comboBoxIngredientsWeight.Items.AddRange(cafeItaly.ListOfProducedPizzasByIngredientWeight.ToArray());
                comboBoxAddToMeal.Items.AddRange(cafeItaly.ListOfProducedDecorator.ToArray());
            }
            else
            {
                comboBoxSelectComposition.Items.AddRange(cafeReadHead.ListOfProducedPizzasByCompositions.ToArray());
                comboBoxIngredientsWeight.Items.AddRange(cafeReadHead.ListOfProducedPizzasByIngredientWeight.ToArray());
                comboBoxAddToMeal.Items.AddRange(cafeReadHead.ListOfProducedDecorator.ToArray());
            }
            // Select composition
            comboBoxSelectComposition.Text = comboBoxSelectComposition.Items[0].ToString();
            comboBoxSelectComposition.SelectedItem = comboBoxSelectComposition.Items[0].ToString();
            // Select Ingredients weight
            comboBoxIngredientsWeight.Text = comboBoxIngredientsWeight.Items[0].ToString();
            comboBoxIngredientsWeight.SelectedItem = comboBoxIngredientsWeight.Items[0].ToString();
            // Select Add to meal
            comboBoxAddToMeal.Text = comboBoxAddToMeal.Items[0].ToString();
            comboBoxAddToMeal.SelectedItem = comboBoxAddToMeal.Items[0].ToString();
        }
        private void SetListBoxPrice(string meal = "", decimal newPrice=0)
        {
            listBoxPrice.Items.Clear();
            comboBoxSelectAMealForChange.Items.Clear();
            PriceInfo priceInfo = market.GetInfo();
            Type myType = Type.GetType(priceInfo.ToString(), false, true);
            StringBuilder p = new StringBuilder();
            bool f = true;
            if(newPrice<=0)
                f = false;
            foreach (MemberInfo property in myType.GetProperties())
            {
                comboBoxSelectAMealForChange.Items.Add(property.Name);
                p.Append(property.Name).Append(" = ");
                if (f && meal == property.Name)
                {
                    priceInfo.GetType().GetProperty(property.Name).SetValue(priceInfo, newPrice);
                    p.Append(newPrice.ToString("f2")).Append(" $");
                }
                else
                {
                    p.Append(priceInfo.GetType().GetProperty(property.Name).GetValue(priceInfo, null).ToString()).Append(" $");
                }
                listBoxPrice.Items.Add(p.ToString());
                p.Clear();
            }
        }

        private void buttonMarketChange_Click(object sender, EventArgs e)
        {
            market.MarketChange();
            SetListBoxPrice();
            market.NotifyObservers();
        }

        private void buttonSetNewPrice_Click(object sender, EventArgs e)
        {
            try
            {
                decimal newPrice = Convert.ToDecimal(textBoxNewPrice.Text);
                SetListBoxPrice(comboBoxSelectAMealForChange.SelectedItem.ToString(), newPrice);
            }
            catch
            {
                MessageBox.Show("Error! Please enter correct value!");
                textBoxNewPrice.Text = "";
            }
        }
    }
}
