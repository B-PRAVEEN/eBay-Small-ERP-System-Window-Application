using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eBayERPSolution
{
    public partial class feesandprofit : Form
    {
        public Int32 ebayfeesperc;
        public float sellingprice;
        public float finalvalue;
        public float paisapayperc;
        public float total;
        public float profit;
        public float loss;
        public float buyitnow;
        public feesandprofit()
        {
            InitializeComponent();
        }

       

        private void feesandprofit_Load(object sender, EventArgs e)
        {
            
            shippingcostl.Enabled = false;
            shippingcosttbox.Enabled = false;
            buyitnowl.Enabled = false;
            buyitnowtbox.Enabled = false;
            startingpricel.Enabled = false;
            startingpricetbox.Enabled = false;
            

        catogory1.Items.Add("Mobile Accessories");
        catogory1.Items.Add("Mobile Phones");
        catogory1.Items.Add("Laptops & Computer Peripherals");//
        catogory1.Items.Add("Tablets & Accesories");
        catogory1.Items.Add("Cameras & Optics");//
        catogory1.Items.Add("LCD, LED & Televisions");
        catogory1.Items.Add("Audio & Home Entertainment"); 
        catogory1.Items.Add("Memory Cards, Pen Drives & HDD");//
        catogory1.Items.Add("Home Appliances");//
        catogory1.Items.Add("Games Consoles & Accessories");//
        catogory1.Items.Add("Clothing & Accessories");//
        catogory1.Items.Add("Shoes & Other Footwear");
        catogory1.Items.Add("Perfumes Cosmetics & Health");
        catogory1.Items.Add("Watches");
        catogory1.Items.Add("Jewellery & Diamonds");
        catogory1.Items.Add("Home & Living");
        catogory1.Items.Add("Kitchenware Dinning & Bar");
        catogory1.Items.Add("Toys, Games & School Supplies");
        catogory1.Items.Add("Bady & Mom");
        catogory1.Items.Add("Coins & Notes");
        catogory1.Items.Add("Stamps");
        catogory1.Items.Add("Collectibles");
        catogory1.Items.Add("Cars & Bike Accessories");
        catogory1.Items.Add("Fitness & Sports");
        catogory1.Items.Add("Books & Magazines");
        catogory1.Items.Add("Movies and Music");
        catogory1.Items.Add("Stationery & Office Supplies");
        catogory1.Items.Add("Tools & Hardware");
        catogory1.Items.Add("Musical Instruments");
        catogory1.Items.Add("eBay Daily");
        catogory1.Items.Add("Everything Else");
        catogory1.Items.Add("Cars & Bikes");
        
        
       
        }

        private void catogory1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (catogory1.SelectedItem == "Mobile Accessories")
            {
                ebayfeesperc = 5;
                subcatogoryl.Enabled = false;
                subcatogorylist.Enabled = false;

            }
            else if (catogory1.SelectedItem == "Mobile Phones") 
            {

                ebayfeesperc = 1;
                subcatogoryl.Enabled = false;
                subcatogorylist.Enabled = false;

            }
            else if(catogory1.SelectedItem=="Laptops & Computer Peripherals")
            {
                subcatogoryl.Enabled = true;
                subcatogorylist.Enabled = true;
                subcatogorylist.Items.Clear();
                subcatogorylist.Items.Add("Desktop PCs,LCD/TFT Monitors, Laptops");
                subcatogorylist.Items.Add("Panel PCs(All in One),Printers, Scanners & Supplies, CD/DVD Drives & Writes, Speakers, Webcams & Multimedia, Networking Equipment, keyboard & Mouse, Computer Components");
                subcatogorylist.Items.Add("Wireless USB Modem, Routers, Laptop Accessories, Software, Internet & Services, PC Tools & Accessories");
            }

            else if (catogory1.SelectedItem=="Tablets & Accesories")
            {
                subcatogoryl.Enabled = true;
                subcatogorylist.Enabled = true;
                subcatogorylist.Items.Clear();
                subcatogorylist.Items.Add("iPads & Tablets");
                subcatogorylist.Items.Add("Rest");
            }

            else if (catogory1.SelectedItem  == "Cameras & Optics")
            {
                subcatogoryl.Enabled = true;
                subcatogorylist.Enabled = true;
                subcatogorylist.Items.Clear();
                subcatogorylist.Items.Add("Digital Cameras, Film Cameras, SLRs, Binoculars");
                subcatogorylist.Items.Add("Microscopes,  Camcorders, Digital Photo Frames, Telescope, SLR Camera Lenses");
                subcatogorylist.Items.Add("Camera, Camcorder Accessories, Other Optics");
            }

            else if (catogory1.SelectedItem == "LCD, LED & Televisions")
            {
                subcatogoryl.Enabled = true;
                subcatogorylist.Enabled = true;
                subcatogorylist.Items.Clear();
                subcatogorylist.Items.Add("TV Accessesories");
                subcatogorylist.Items.Add("Rest");
                
            }

            else if (catogory1.SelectedItem == "Audio & Home Entertainment")
            {
                subcatogoryl.Enabled = true;
                subcatogorylist.Enabled = true;
                subcatogorylist.Items.Clear();
                subcatogorylist.Items.Add("Projectors & Accessories");
                subcatogorylist.Items.Add("Apple iPods, MP3 & MP4 Players, Portable Audio & Video, Everything Else, DVD / VCD Players,DVD/VCD Accessories, Audio Devices, Head Phones, Head Sets, Home Theatre & Accessories,");
                subcatogorylist.Items.Add("Telephone Devices, Batteries & Chargers, Batteries & Chargers, Apple iPod Accessories, MP3 Accessories");

            }
            else if (catogory1.SelectedItem == "Memory Cards, Pen Drives & HDD")

            {
                ebayfeesperc = 1;
                subcatogoryl.Enabled = false;
                subcatogorylist.Enabled = false;

 
            }
            else if (catogory1.SelectedItem == "Home Appliances")
            {
                subcatogoryl.Enabled = true;
                subcatogorylist.Enabled = true;
                subcatogorylist.Items.Clear();
                subcatogorylist.Items.Add("Home Security Systems, Other Home Appliances");
                subcatogorylist.Items.Add("Rest");

            }
            else if (catogory1.SelectedItem == "Games Consoles & Accessories")
            {
                ebayfeesperc = 1;
                subcatogoryl.Enabled = false;
                subcatogorylist.Enabled = false;
            }
            else if (catogory1.SelectedItem == "Clothing & Accessories")
            {
                subcatogoryl.Enabled = true;
                subcatogorylist.Enabled = true;
                subcatogorylist.Items.Clear();
                subcatogorylist.Items.Add("Wholesale Lots");
                subcatogorylist.Items.Add("Rest");

            }
            else if (catogory1.SelectedItem == "Shoes & Other Footwear")
            {
                ebayfeesperc = 7;
                subcatogoryl.Enabled = false;
                subcatogorylist.Enabled = false;
            }
            else if (catogory1.SelectedItem == "Perfumes Cosmetics & Health")
            {
                subcatogoryl.Enabled = true;
                subcatogorylist.Enabled = true;
                subcatogorylist.Items.Clear();
                subcatogorylist.Items.Add("Bath & Body, Make Up & Cosmetics, Deodorants, Nail Care & Polish, Shaving & Hair Removal, Shampoo, Powder & Talc, Toners & Astringents");
                subcatogorylist.Items.Add("Perfumes & Fragrances, Skin Care, Hair Care, Health Care & Instruments, Massage, Shaving & Hair Removal, Other");
                subcatogorylist.Items.Add("Wholesale Lots");
            }
            else if (catogory1.SelectedItem == "Watches")
            {
                ebayfeesperc = 7;
                subcatogoryl.Enabled = false;
                subcatogorylist.Enabled = false;
                 
            }
            else if (catogory1.SelectedItem == "Jewellery & Diamonds")
            {
                subcatogoryl.Enabled = true;
                subcatogorylist.Enabled = true;
                subcatogorylist.Items.Clear();
                subcatogorylist.Items.Add("Diamond Jewellery, Gemstone Jewellery, Loose Diamonds, Sterling Silver Jewellery");
                subcatogorylist.Items.Add("Precious Metal Coins & Bars, Gold Jewellery");
                subcatogorylist.Items.Add("Fashion & Imitation Jewellery,Loose Gemstones & Pearls, Jewellery Storage & Cleaners");
            }
            else if (catogory1.SelectedItem == "Home & Living")
            {
                ebayfeesperc = 5;
                subcatogoryl.Enabled = false;
                subcatogorylist.Enabled = false;
                
            }
            else if (catogory1.SelectedItem == "Kitchenware Dinning & Bar")
            {
                ebayfeesperc = 7;
                subcatogoryl.Enabled = false;
                subcatogorylist.Enabled = false;
                 
            }
            else if (catogory1.SelectedItem == "Toys, Games & School Supplies")
            {

                ebayfeesperc = 7;
                subcatogoryl.Enabled = false;
                subcatogorylist.Enabled = false;

            }
            else if (catogory1.SelectedItem == "Bady & Mom")
            {
                subcatogoryl.Enabled = true;
                subcatogorylist.Enabled = true;
                subcatogorylist.Items.Clear();
                subcatogorylist.Items.Add("Baby Bath,Grooming,Skin Care,Baby Food & Feeding Items, Baby Gift Packs, Baby Health & Safety");
                subcatogorylist.Items.Add("Rest");
            }

            else if (catogory1.SelectedItem == "Coins & Notes")
            {

                ebayfeesperc = 5;
                subcatogoryl.Enabled = false;
                subcatogorylist.Enabled = false;
            }
            else if (catogory1.SelectedItem == "Stamps")
            {
                ebayfeesperc = 5;
                subcatogoryl.Enabled = false;
                subcatogorylist.Enabled = false;
            }
            else if (catogory1.SelectedItem == "Collectibles")
            {
                ebayfeesperc = 5;
                subcatogoryl.Enabled = false;
                subcatogorylist.Enabled = false;

            }
            else if (catogory1.SelectedItem == "Cars & Bike Accessories")
            {
                ebayfeesperc = 7;
                subcatogoryl.Enabled = false;
                subcatogorylist.Enabled = false;
 
            }
            else if (catogory1.SelectedItem == "Fitness & Sports")
            {
                ebayfeesperc = 7;
                subcatogoryl.Enabled = false;
                subcatogorylist.Enabled = false;

            }
            else if (catogory1.SelectedItem == "Books & Magazines")
            {
                ebayfeesperc = 6;
                subcatogoryl.Enabled = false;
                subcatogorylist.Enabled = false;
 
            }
            else if (catogory1.SelectedItem == "Movies and Music")
            {
                ebayfeesperc = 6;
                subcatogoryl.Enabled = false;
                subcatogorylist.Enabled = false;
            }

            else if (catogory1.SelectedItem == "Stationery & Office Supplies")
            {
                subcatogoryl.Enabled = true;
                subcatogorylist.Enabled = true;
                subcatogorylist.Items.Clear();
                subcatogorylist.Items.Add("Office Electronics");
                subcatogorylist.Items.Add("Rest");

            }

            else if (catogory1.SelectedItem == "Tools & Hardware")
            {
                ebayfeesperc = 7;
                subcatogoryl.Enabled = false;
                subcatogorylist.Enabled = false;

            }
            else if (catogory1.SelectedItem == "Musical Instruments")
            {
                subcatogoryl.Enabled = false;
                subcatogorylist.Enabled = false;

                ebayfeesperc = 7;
            }
            else if (catogory1.SelectedItem == "eBay Daily")
            {
                subcatogoryl.Enabled = false;
                subcatogorylist.Enabled = false;

                ebayfeesperc = 7;
            }

            else if (catogory1.SelectedItem == "Everything Else")
            {
                subcatogoryl.Enabled = false;
                subcatogorylist.Enabled = false;

                ebayfeesperc = 7;
            }

            else if (catogory1.SelectedItem.ToString().Equals("Cars & Bikes"))
            {
                subcatogoryl.Enabled = false;
                subcatogorylist.Enabled = false;

                ebayfeesperc = 7;
            }

            
            catogoryfeesl.Text = ebayfeesperc.ToString() + "%";
            finalvalue = (sellingprice / 100);
            finalvalue = finalvalue * ebayfeesperc;
            finalvaluefeesl.Text = finalvalue.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void subcatogorylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
        }

        

        private void subcatogorylist_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            if (subcatogorylist.SelectedItem.ToString().Equals("Desktop PCs,LCD/TFT Monitors, Laptops"))
            {
                ebayfeesperc = 1;
            }

            if(subcatogorylist.SelectedItem.ToString().Equals("Panel PCs(All in One),Printers, Scanners & Supplies, CD/DVD Drives & Writes, Speakers, Webcams & Multimedia, Networking Equipment, keyboard & Mouse, Computer Components"))

            {
                ebayfeesperc = 2;
            }

            if (subcatogorylist.SelectedItem.ToString().Equals("Wireless USB Modem, Routers, Laptop Accessories, Software, Internet & Services, PC Tools & Accessories"))
            {
                ebayfeesperc = 5;

 
            }
            if (subcatogorylist.SelectedItem.ToString().Equals("iPads & Tablets"))
            {
                ebayfeesperc = 1;
 
            }

            if (subcatogorylist.SelectedItem.ToString().Equals("Rest"))
            {
                ebayfeesperc = 2;

            }

            if (subcatogorylist.SelectedItem.ToString().Equals("Digital Cameras, Film Cameras, SLRs, Binoculars"))
            {
                ebayfeesperc = 1;

            }

            if (subcatogorylist.SelectedItem.ToString().Equals("Microscopes,  Camcorders, Digital Photo Frames, Telescope, SLR Camera Lenses"))
            {
                ebayfeesperc = 2;
            }

            if (subcatogorylist.SelectedItem.ToString().Equals("Camera, Camcorder Accessories, Other Optics"))
            {
                ebayfeesperc = 5;
            }

            if (subcatogorylist.SelectedItem.ToString().Equals("TV Accessesories"))
            {
                ebayfeesperc = 5;
            }

            if (subcatogorylist.SelectedItem.ToString().Equals("Rest"))
            {
                ebayfeesperc = 1;
            }

            if (subcatogorylist.SelectedItem.ToString().Equals("Projectors & Accessories"))
            {
                ebayfeesperc = 1;
            }

            if (subcatogorylist.SelectedItem.ToString().Equals("Apple iPods, MP3 & MP4 Players, Portable Audio & Video, Everything Else, DVD / VCD Players,DVD/VCD Accessories, Audio Devices, Head Phones, Head Sets, Home Theatre & Accessories,"))
            {
                ebayfeesperc = 2;
            }
            if (subcatogorylist.SelectedItem.ToString().Equals("Telephone Devices, Batteries & Chargers, Batteries & Chargers, Apple iPod Accessories, MP3 Accessories"))
            {
                ebayfeesperc = 2;
            }

            if (subcatogorylist.SelectedItem.ToString().Equals("Home Security Systems, Other Home Appliances"))
            {
                ebayfeesperc = 5;
            }

            if (subcatogorylist.SelectedItem.ToString().Equals("Rest"))
            {
                ebayfeesperc = 1;
            }


            if (subcatogorylist.SelectedItem.ToString().Equals("Wholesale Lots"))
            {
                ebayfeesperc = 1;
            }

            if (subcatogorylist.SelectedItem.ToString().Equals("Rest"))
            {
                ebayfeesperc = 7;
            }

            if (subcatogorylist.SelectedItem.ToString().Equals("Bath & Body, Make Up & Cosmetics, Deodorants, Nail Care & Polish, Shaving & Hair Removal, Shampoo, Powder & Talc, Toners & Astringents"))
            {
                ebayfeesperc = 2;
            }
            if (subcatogorylist.SelectedItem.ToString().Equals("Perfumes & Fragrances, Skin Care, Hair Care, Health Care & Instruments, Massage, Shaving & Hair Removal, Other"))
            {
                ebayfeesperc = 7;
            }

            if (subcatogorylist.SelectedItem.ToString().Equals("Wholesale Lots"))
            {
                ebayfeesperc = 1;
            }

            if (subcatogorylist.SelectedItem.ToString().Equals("Diamond Jewellery, Gemstone Jewellery, Loose Diamonds, Sterling Silver Jewellery"))
            {
                ebayfeesperc = 5;
            }


            if (subcatogorylist.SelectedItem.ToString().Equals("Precious Metal Coins & Bars, Gold Jewellery"))
            {
                ebayfeesperc = 1;
            }

            if (subcatogorylist.SelectedItem.ToString().Equals("Fashion & Imitation Jewellery,Loose Gemstones & Pearls, Jewellery Storage & Cleaners"))
            {
                ebayfeesperc = 7;
            }


            if (subcatogorylist.SelectedItem.ToString().Equals("Baby Bath,Grooming,Skin Care,Baby Food & Feeding Items, Baby Gift Packs, Baby Health & Safety"))
            {
                ebayfeesperc = 2;
            }


            if (subcatogorylist.SelectedItem.ToString().Equals("Rest"))
            {
                ebayfeesperc = 7;
            }

            if (subcatogorylist.SelectedItem.ToString().Equals("Office Electronics"))
            {
                ebayfeesperc = 5;

            }

        

            if (subcatogorylist.SelectedItem.ToString().Equals("Rest"))
            {
                ebayfeesperc = 7;
            }


            catogoryfeesl.Text = ebayfeesperc.ToString() + "%";
            finalvalue = (sellingprice / 100) * ebayfeesperc;
            finalvaluefeesl.Text = finalvalue.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            powershipbox.Enabled = false;
            shippingcostlable.Text = shippingcosttbox.Text;
            shippingcostl.Enabled = true;
            shippingcosttbox.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            powershipbox.Enabled = true;
            shippingcostl.Enabled = false;
            shippingcosttbox.Enabled = false;
            shippingcostlable.Text = " ";
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            sellingpricetbox.Enabled = true;
            sellingpricelable.Enabled = true;
            buyitnowl.Enabled = false;
            buyitnowtbox.Enabled = false;
            startingpricel.Enabled = false;
            startingpricetbox.Enabled = false;

        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Fees will be calculate on the final auction price and I can not predict the auction price but i will tell you the fees based on BuyitNow Price.");
            sellingpricetbox.Text = "00";
            sellingpricetbox.Enabled = false;
            sellingpricelable.Enabled = false;
            buyitnowl.Enabled = true;
            buyitnowtbox.Enabled = true;
            startingpricel.Enabled = true;
            startingpricetbox.Enabled = true;


        }

        private void button1_Click(object sender, EventArgs e)
        {

                    

            if (fixedr.Checked == true)
            {
                    if (nonbasic.Checked == true)
                    {
                        if (listingduration.SelectedItem.ToString().Equals("1") || listingduration.SelectedItem.ToString().Equals("3") || listingduration.SelectedItem.ToString().Equals("5") || listingduration.SelectedItem.ToString().Equals("7"))
                        {
                            listingfeesl.Text = "2";
                        }
                        else if (listingduration.SelectedItem.ToString().Equals("30"))
                        {
                            listingfeesl.Text = "5";
                        }

                        else
                            MessageBox.Show("Listing For 10 Days is not Avilable in Fixed Selling Format");
                    }


                    else if (basic.Checked == true)
                    {
                        if (listingduration.SelectedItem.ToString().Equals("1") || listingduration.SelectedItem.ToString().Equals("3") || listingduration.SelectedItem.ToString().Equals("5") || listingduration.SelectedItem.ToString().Equals("7"))
                        {
                            listingfeesl.Text = "1";
                        }
                        else if (listingduration.SelectedItem.ToString().Equals("30"))
                        {
                            listingfeesl.Text = "2";
                        }
                        else
                            MessageBox.Show("Listing For 10 Days is not Avilable in Fixed Selling Format");
                    }
                    else if (featured.Checked == true)
                    {
                        if (listingduration.SelectedItem.ToString().Equals("1") || listingduration.SelectedItem.ToString().Equals("3") || listingduration.SelectedItem.ToString().Equals("5") || listingduration.SelectedItem.ToString().Equals("7"))
                        {
                            listingfeesl.Text = "0.5";
                        }
                        else if (listingduration.SelectedItem.ToString().Equals("30"))
                        {
                            listingfeesl.Text = "1";
                        }
                        else
                            MessageBox.Show("Listing For 10 Days is not Avilable in Fixed Selling Format");
                    }

                    else if (premium.Checked == true)
                    {
                        if (listingduration.SelectedItem.ToString().Equals("1") || listingduration.SelectedItem.ToString().Equals("3") || listingduration.SelectedItem.ToString().Equals("5") || listingduration.SelectedItem.ToString().Equals("7"))
                        {
                            listingfeesl.Text = "0.25";
                        }
                        else if (listingduration.SelectedItem.ToString().Equals("30"))
                        {
                            listingfeesl.Text = "0.5";
                        }
                        else
                            MessageBox.Show("Listing For 10 Days is not Avilable in Fixed Selling Format");


                    }
                }

            else if (auctionr.Checked == true)
            {
                if (listingduration.SelectedItem.ToString().Equals("1") || listingduration.SelectedItem.ToString().Equals("3") || listingduration.SelectedItem.ToString().Equals("5"))
                {
                   listingfeesl.Text = "Free";
                }

                else if (listingduration.SelectedItem.ToString().Equals("10"))
                {
                    listingfeesl.Text = "10";
                }

                else
                    listingfeesl.Text = "25";

            }

           

            if (sellingpriceinclur.Checked == true)
            {
                sellingpricedisplayl.Text = sellingpricetbox.Text;
                float sellingprice;

                sellingprice = float.Parse(sellingpricedisplayl.Text) - float.Parse(shippingcostlable.Text);
                sellingpricedisplayl.Text = sellingprice.ToString();
                total = float.Parse(sellingpricedisplayl.Text) + float.Parse(shippingcostlable.Text);
                totall.Text = total.ToString();
            }

            else if (sellingpricenoinclur.Checked == true)
            {

                sellingpricedisplayl.Text = sellingpricetbox.Text;
                total = float.Parse(sellingpricedisplayl.Text) + float.Parse(shippingcostlable.Text);
                totall.Text = total.ToString();

            }


            // CALCULATION PROCESS
            float paisapayfees;
            float css;
            float tax;
            paisapayfees = (total / 100) * paisapayperc;
            tax = (paisapayfees / 100) * 12;
            css = (tax / 100) * 3;
            paisapayfees = paisapayfees + tax + css;
            paisapayfeesl.Text = paisapayfees.ToString() + "Inc.(Tax)";

            profit = (((total - finalvalue) - paisapayfees) - float.Parse(costpricetbox.Text))-float.Parse(shippingcostlable.Text) ;
            if (profit > 0)
            {
                profitl.Text = profit.ToString();
                lossl.Text = "0";
            }
            else if (profit < 0)
            {

                loss = profit;
                lossl.Text = loss.ToString();
                profitl.Text = "0";

            //CALCULATION END
 
            }
                

        }



        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void sellingpricetbox_TextChanged(object sender, EventArgs e)
       {
            sellingpricedisplayl.Text = sellingpricetbox.Text;
            sellingprice = float.Parse(sellingpricetbox.Text);
        }

        private void shippingcosttbox_TextChanged(object sender, EventArgs e)
        {
            shippingcostlable.Text = shippingcosttbox.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (localr.Checked == true)
            {
                slot250.Enabled = true;
                if (sellingprice <= 500)
                {
                    if (slot250.Checked == true)
                    {
                        shippingcostlable.Text = "32.5";
                       
                    }

                    else if (slot500.Checked == true)
                    {
                        shippingcostlable.Text = "32.5";
            
            
                    }

                                        
                }

                else if (sellingprice > 501 && sellingprice < 25000)
                {
                    slot250.Enabled = false;
                    
                    if (localr.Checked == true)
                    {

                        if (slot500.Checked == true)
                        {
                            shippingcostlable.Text = "48.3";
                          
                        }

                        
                    }
                }
                else

                shippingcostlable.Text = "54";
               
            }

            if (metror.Checked == true)
            {
                if (sellingprice < 500)
                {
                    slot250.Enabled = true;
                    if (slot250.Checked == true)
                    {
                        shippingcostlable.Text = "37.7";
                        
                    }

                    else if (slot500.Checked == true)
                    {
                        shippingcostlable.Text = "48.3";
                        
                    }

                                       
                    

                }

                else if (sellingprice > 501 && sellingprice < 25000)
                {
                    slot250.Enabled = false;

                    if (slot500.Checked == true)
                    {
                        shippingcostlable.Text = "48.3";
                       
                    }

                    
                }
                else

                shippingcostlable.Text = "99";   //COD CHECK 
                

            }

            if (nationalr.Checked==true)
            {
                if (sellingprice < 500)
                {
                    slot250.Enabled = true;
                    if (slot250.Checked == true)
                    {
                        shippingcostlable.Text = "37.7";
                     

                    }

                    else if (slot500.Checked == true)
                    {
                        shippingcostlable.Text = "48.3";
                        
                    }

                                    }

                else if (sellingprice > 501 && sellingprice < 25000)
                {
                    slot250.Enabled = false;

                    if (slot500.Checked == true)
                    {
                        shippingcostlable.Text = "48.3";
                       
                    }

                        }

                else
                    shippingcostlable.Text = "99";
                    

            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void upgradefeesl_Click(object sender, EventArgs e)
        {

        }

        private void lineShape1_Click(object sender, EventArgs e)
        {

        }

        private void lable18_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            upgradefeesl.Text = textBox1.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (paisapayservicelist.SelectedItem.ToString().Equals("PaisaPay Facility Charge for EMI"))
            {
                paisapayperc = 4.5F;
                servicefeesl.Text  = paisapayperc.ToString();
            }

            else
                paisapayperc = 4.5f;
            servicefeesl.Text = paisapayperc.ToString();

        }

        private void paisapayfeesl_Click(object sender, EventArgs e)
        {

        }

        private void sellingpriceinclur_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

       

        
    }
}
