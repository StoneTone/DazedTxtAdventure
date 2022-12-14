using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Channels;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectAS
{
    public partial class worldBuild : Form
    {
        int counter = 0;
        int len = 0;
        string text;
        bool flash,skey,brkey;
        bool sinkOff = false;
        
        
        
        private int One, Two, Three, Four;
        
        private string code;
        public worldBuild()
        {
            InitializeComponent();
            
            worldBuildLabel.MaximumSize = new Size(450, 250);
            worldBuildLabel.AutoSize = true;
            nextForm.Show();

            textScroll.Start();
            worldBuildLabel.Text = "You wake up, cold. You open your eyes to see " +
                "you're not in your room. It's dark and you can't see anything";

            //exit code that is randomized
            Random ran = new Random();
            One = ran.Next(0, 9);
            Two = ran.Next(0, 9);
            Three = ran.Next(0, 9);
            Four = ran.Next(0, 9);
            code = One.ToString() + Two.ToString() + Three.ToString() + Four.ToString();


        }

        private void worldBuild_Load(object sender, EventArgs e)
        {
            
            text = worldBuildLabel.Text;
            len = text.Length;
        }



        //----------------------------------------------End of Variables-----------------------------------------------//
        //-----------------------------------------Start of Story----------------------------------------------------//

        private void getUp()
        {
            counter = 0;
            
            worldBuildLabel.Text = "You get up from the bed and look around. You see a " +
                                     "nightstand with a flashlight next to you.";
            text = worldBuildLabel.Text;
            len = text.Length;


            textScroll.Start();
            nextForm.Visible = false;
            ActionButton2.Show();
            ActionButton2.Text = "Grab";
            ActionButton2.Click += FlashGrabbed;
            
            
        }

        private void grabFlash ()
        {
            
            counter = 0;
            
            worldBuildLabel.Text = "You grab the flashlight and look around there is a " +
                                      "a nightstand, a dresser and a door";

            text = worldBuildLabel.Text;
            len = text.Length;

            nextForm.Visible = false;
            codeTextBox.Visible = false;
            textScroll.Start();
            
        }

       private void FlashGrabbed(object sender,EventArgs e)
        {
                grabFlash();
                flash = true;
                itemLabel.ForeColor = Color.Lime;
                itemLabel.Text = "+ Flashlight";
                itemFade.Start();
            
                itemLabel.Show();
                
                ActionButton1.Show();
                ActionButton2.Show();
                ActionButton3.Show();

                ActionButton1.Text = "Nightstand";
                ActionButton2.Text = "Dresser";
                ActionButton3.Text = "Door";

                ActionButton1.Click += Dresser;
                ActionButton2.Click += NightStand;
                ActionButton3.Click += Door;
        }

        //--------------------------------Bedroom Options---------------------------------------------------//
        private void NightStand(object sender, EventArgs e)
        {
            counter = 0;
            worldBuildLabel.Text = "You look in the nightstand. You see an old bible that is in bad shape";

            text = worldBuildLabel.Text;
            len = text.Length;
            
            

            nextForm.Visible = false;
            codeTextBox.Visible = false;
            textScroll.Start();

            itemLabel.Hide();
            ActionButton1.Show();
            ActionButton1.Text = "Back";
            ActionButton2.Hide();
            ActionButton3.Show();
            ActionButton3.Text = "Bible";

            ActionButton1.Click += FlashGrabbed;
            ActionButton3.Click += Bible;
        }

        private void Bible(object sender,EventArgs e)
        {
            brkey = true;
            itemLabel.ForeColor = Color.Lime;
            counter = 0;
            worldBuildLabel.Text = "The bible is in bad shape. You open it to see a perfect cut in the bible where there is a key";
            
            text = worldBuildLabel.Text;
            len = text.Length;
            
            itemLabel.Text = "+ Bedroom Key";
            itemLabel.Show();
            itemFade.Start();
            

            nextForm.Visible = false;
            codeTextBox.Visible = false;
            textScroll.Start();

            
            ActionButton1.Hide();
            ActionButton2.Show();
            ActionButton2.Text = "Back";
            ActionButton3.Hide();

            ActionButton2.Click += FlashGrabbed;
        }

        private void Dresser(object sender,EventArgs e)
        {
            counter = 0;
            worldBuildLabel.Text = "You look in the dresser. It's empty however you see the number " + One + " engraved on the bottom";

            text = worldBuildLabel.Text;
            len = text.Length;

            nextForm.Visible = false;
            codeTextBox.Visible = false;
            textScroll.Start();

            itemLabel.Hide();
            ActionButton1.Hide();
            ActionButton2.Show();
            ActionButton2.Text = "Back";
            ActionButton3.Hide();

            ActionButton2.Click += FlashGrabbed;
        }

        private void Door(object sender, EventArgs e)
        {
            counter = 0;

            if(brkey == false)
            {
                worldBuildLabel.Text = "You try to open the door. It wont budge. Looks like it needs a key";

                text = worldBuildLabel.Text;
                len = text.Length;

                nextForm.Visible = false;
                codeTextBox.Visible = false;
                textScroll.Start();

                itemLabel.Hide();
                ActionButton1.Hide();
                ActionButton2.Show();
                ActionButton2.Text = "Back";
                ActionButton3.Hide();

                ActionButton2.Click += FlashGrabbed;
            }
            else
            {
                worldBuildLabel.Text = "You use the key you found to unlock the door.";

                text = worldBuildLabel.Text;
                len = text.Length;

                nextForm.Visible = false;
                codeTextBox.Visible = false;
                textScroll.Start();

                itemLabel.Hide();
                ActionButton1.Hide();
                ActionButton2.Show();
                ActionButton2.Text = "Open";
                ActionButton3.Hide();

                ActionButton2.Click += DoorUnlocked;
            }
            
        }
        //--------------------------------End Bedroom---------------------------------------------------//
        //--------------------------------Player Back to Bed---------------------------------------------------//
        private void BackBedroom(object sender, EventArgs e)
        {
            worldBuildLabel.Text = "'Why am I going back in here? I don't need to be in here', you say to yourself";

            text = worldBuildLabel.Text;
            len = text.Length;

            nextForm.Visible = false;
            codeTextBox.Visible = false;
            textScroll.Start();

            itemLabel.Hide();

            ActionButton1.Hide();
            ActionButton2.Show();
            ActionButton2.Text = "Back";
            ActionButton3.Hide();

            ActionButton2.Click += DoorUnlocked;

        }

        //--------------------------------End Back to Bed---------------------------------------------------//
        //--------------------------------Door Unlocked---------------------------------------------------//
        private void DoorUnlocked(object sender, EventArgs e)
        {
            worldBuildLabel.Text = "You open the door to see a long hallway. You step outside of the bedroom and yell 'Hello?', no response. ";

            text = worldBuildLabel.Text;
            len = text.Length;

            nextForm.Visible = false;
            codeTextBox.Visible = false;
            textScroll.Start();

            itemLabel.Hide();
            ActionButton1.Show();
            ActionButton1.Text = "Go left";
            ActionButton2.Show();
            ActionButton2.Text = "Go right";
            ActionButton3.Show();
            ActionButton3.Text = "Back";


            ActionButton1.Click += GoLeft;
            ActionButton2.Click += GoRight;
            ActionButton3.Click += BackBedroom;
        }
        //--------------------------------End of BDoor---------------------------------------------------//
        //--------------------------------Hallway Options---------------------------------------------------//
        //--------------------------------Left---------------------------------------------------//
        private void GoLeft(object sender, EventArgs e)
        {
            worldBuildLabel.Text = "You walk down the hallway to your left. You see stairs to your right, a door in front of you that has a lock on it and an entry way to another room. ";

            text = worldBuildLabel.Text;
            len = text.Length;

            
            textScroll.Start();

            itemLabel.Hide();
            ActionButton1.Show();
            ActionButton1.Text = "Upstairs";
            ActionButton2.Show();
            ActionButton2.Text = "Entry";
            ActionButton3.Show();
            ActionButton3.Text = "Door";
            nextForm.Show();
            nextForm.Text = "Back";

            ActionButton1.Click += UpStairs;
            ActionButton2.Click += Entry;
            ActionButton3.Click += LockedDoor;
            nextForm.Click += DoorUnlocked;
        }

        private void UpStairs(object sender, EventArgs e)
        {
            worldBuildLabel.Text = "You look up at the stairs and see a couch that's blocking your path upwards." +
                " You murmur to yourself, 'Damn developers'.";

            text = worldBuildLabel.Text;
            len = text.Length;

            nextForm.Visible = false;
            codeTextBox.Visible = false;
            textScroll.Start();

            itemLabel.Hide();

            ActionButton1.Hide();
            ActionButton2.Show();
            ActionButton2.Text = "Sorry";
            ActionButton3.Hide();

            ActionButton2.Click += GoLeft;
        }
        //-------------------------------Living room-------------------------------------------------------------//
        private void Entry(object sender, EventArgs e)
        {
            worldBuildLabel.Text = "You walk through the entry way to see a living room. There are some furniture, however everthing is " +
                "covered up with white sheets. You see a china cabinet, a piano and another entry way.";

            text = worldBuildLabel.Text;
            len = text.Length;

            nextForm.Visible = false;
            codeTextBox.Visible = false;
            textScroll.Start();

            itemLabel.Hide();

            ActionButton1.Show();
            ActionButton1.Text = "Cabinet";
            ActionButton2.Show();
            ActionButton2.Text = "Piano";
            ActionButton3.Show();
            ActionButton3.Text = "Entry";
            nextForm.Show();
            nextForm.Text = "Back";

            
            ActionButton1.Click += ChinaCabinet;
            ActionButton2.Click += Piano;
            ActionButton3.Click += Kitchen;
            nextForm.Click += GoLeft;

        }
        private void ChinaCabinet(object sender, EventArgs e)
        {
            worldBuildLabel.Text = "You walk up to the china cabinet. It's all dusty with just some broken vases. However on the glass you " +
                "see the number " + Two + " on it";

            text = worldBuildLabel.Text;
            len = text.Length;

            nextForm.Visible = false;
            codeTextBox.Visible = false;
            textScroll.Start();

            itemLabel.Hide();

            ActionButton1.Hide();
            ActionButton2.Show();
            ActionButton2.Text = "Back";
            ActionButton3.Hide();

            ActionButton2.Click += Entry;
        }

        private void Piano(object sender, EventArgs e)
        {
            worldBuildLabel.Text = "You look at the piano and sit down at the chair. You attempt to try and play a song you remember from your" +
                " childhood. But then you remembered that you weren't very good at piano. So you stopped trying and hit the F key.";

            text = worldBuildLabel.Text;
            len = text.Length;

            nextForm.Visible = false;
            codeTextBox.Visible = false;
            textScroll.Start();

            itemLabel.Hide();

            ActionButton1.Hide();
            ActionButton2.Show();
            ActionButton2.Text = "Back";
            ActionButton3.Hide();

            ActionButton2.Click += Entry;
        }
        //-------------------------------End Living Room-------------------------------------------------------------//
        private void LockedDoor(object sender, EventArgs e)
        {
            worldBuildLabel.Text = "It looks like the door to outside. However the door is locked with a padlock with a number combination. ";

            text = worldBuildLabel.Text;
            len = text.Length;

            nextForm.Visible = false;
            codeTextBox.Visible = false;
            textScroll.Start();

            itemLabel.Hide();

            ActionButton1.Show();
            ActionButton1.Text = "Unlock?";
            ActionButton2.Hide();
            ActionButton3.Show();
            ActionButton3.Text = "Back";

            ActionButton1.Click += AttemptUnlock;
            ActionButton3.Click += GoLeft;
        }

        private void AttemptUnlock(object sender, EventArgs e)
        {
            worldBuildLabel.Text = "You look at the lock. There are 4 turn dials with numbers from 0-9";
            codeTextBox.Visible = true;
            text = worldBuildLabel.Text;
            len = text.Length;

            nextForm.Visible = false;
            textScroll.Start();

            itemLabel.Hide();

            ActionButton1.Show();
            ActionButton1.Text = "Enter";
            ActionButton2.Hide();
            ActionButton3.Show();
            ActionButton3.Text = "Back";

            ActionButton1.Click += EnterCode;
            ActionButton3.Click += GoLeft;
        }

        private void EnterCode(object sender, EventArgs e)
        {
            codeTextBox.Visible = true;
            if(codeTextBox.Text == code)
            {
                worldBuildLabel.Text = "You enter the code " + codeTextBox.Text + ". The lock opens. You open the door" +
                    " to bright sky. You're free. Finally free.";

                text = worldBuildLabel.Text;
                len = text.Length;

                nextForm.Visible = false;
                

                itemLabel.Hide();

                ActionButton1.Hide();
                ActionButton2.Hide();
                ActionButton3.Hide();

                
            }
            else
            {
                worldBuildLabel.Text = "You enter the code " + codeTextBox.Text + ". The lock wont budge";

                text = worldBuildLabel.Text;
                len = text.Length;

                nextForm.Visible = false;
                

                itemLabel.Hide();

                ActionButton1.Show();
                ActionButton1.Text = "Enter";
                ActionButton2.Hide();
                ActionButton3.Show();
                ActionButton3.Text = "Back";

                ActionButton1.Click += EnterCode;
                ActionButton3.Click += GoLeft;
            }
            textScroll.Start();
        }
        //--------------------------------End Left---------------------------------------------------//
        //--------------------------------Right---------------------------------------------------//
        private void GoRight(object sender, EventArgs e)
        {
            worldBuildLabel.Text = "You walk to the right down the hallway to see an entry way to what appears to be a kitchen. However you notice " +
                "a small hole in the wall that could fit a key.";

            text = worldBuildLabel.Text;
            len = text.Length;

            nextForm.Visible = false;
            codeTextBox.Visible = false;
            textScroll.Start();

            itemLabel.Hide();
            ActionButton1.Show();
            ActionButton1.Text = "Kitchen";
            ActionButton2.Show();
            ActionButton2.Text = "Keyhole";
            ActionButton3.Show();
            ActionButton3.Text = "Back";


            ActionButton1.Click += Kitchen;
            ActionButton2.Click += Keyhole;
            ActionButton3.Click += DoorUnlocked;
        }

        private void Keyhole(object sender, EventArgs e)
        {
            text = worldBuildLabel.Text;
            len = text.Length;
            itemLabel.Hide();

            nextForm.Visible = false;
            codeTextBox.Visible = false;
            

            if (skey == true)
            {
                worldBuildLabel.Text = "You insert the strange key into the hole. Turn it once to have the wall open up like a door.";

                ActionButton1.Show();
                ActionButton1.Text = "Walk-In";
                ActionButton2.Hide();
                ActionButton3.Show();
                ActionButton3.Text = "Back";

                ActionButton1.Click += SecretRoom;
                ActionButton3.Click += GoRight;
            }
            else
            {
                worldBuildLabel.Text = "You try to look inside the keyhole however it is too dark to see inside.";

                ActionButton1.Hide();
                ActionButton2.Hide();
                ActionButton3.Show();
                ActionButton3.Text = "Back";

                ActionButton3.Click += GoRight;
            }
            textScroll.Start();
            
        }

        private void SecretRoom(object sender, EventArgs e)
        {
            worldBuildLabel.Text = "You walk inside the room to see a dark decent down to a basement. On the wall you see the number "
                + Four + " engraved on the wall below it you see four letters. 'D,C,K,S' with the engraved number above the S.";

            text = worldBuildLabel.Text;
            len = text.Length;

            nextForm.Visible = false;
            codeTextBox.Visible = false;
            textScroll.Start();

            itemLabel.Hide();

            ActionButton1.Show();
            ActionButton1.Text = "Basement";
            ActionButton2.Hide();
            ActionButton3.Show();
            ActionButton3.Text = "Back";

            ActionButton1.Click += Basement;
            ActionButton3.Click += GoRight;
        }

        private void Basement(object sender, EventArgs e)
        {
            worldBuildLabel.Text = "You look down the stairs with your flashlight. Put one foot down on the stairs and get too scared " +
                "and chicken out.";

            text = worldBuildLabel.Text;
            len = text.Length;

            nextForm.Visible = false;
            codeTextBox.Visible = false;
            textScroll.Start();

            itemLabel.Hide();

            ActionButton1.Hide();
            ActionButton2.Show();
            ActionButton2.Text = "Back";
            ActionButton3.Hide();

            ActionButton2.Click += SecretRoom;
        }
        //--------------------------------End Right---------------------------------------------------//
        //--------------------------------Kitchen---------------------------------------------------//
        private void Kitchen(object sender,EventArgs e)
        {
            text = worldBuildLabel.Text;
            len = text.Length;

            nextForm.Visible = false;
            codeTextBox.Visible = false;
            itemLabel.Hide();
            

            if (sinkOff == false)
            {
                worldBuildLabel.Text = "You walk in the kitchen to see cabinet doors broken, an island that is split in half. You take a " +
               "step onto the tile to the floor being wet because of the sink overflowing due to the water being on.";

                ActionButton1.Show();
                ActionButton1.Text = "Living Room";
                ActionButton2.Show();
                ActionButton2.Text = "Hallway";
                ActionButton3.Show();
                ActionButton3.Text = "Sink";

                ActionButton1.Click += Entry;
                ActionButton2.Click += GoRight;
                ActionButton3.Click += Sink;
                
            }
            if(sinkOff == true)
            {
                worldBuildLabel.Text = "You walk in the kitchen to see cabinet doors broken, an island that is split in half. You take a " +
               "step onto the wet tile floor that hasn't dried yet from the water. You notice that on one of the cabinet doors there is a number " +
               Three + " engraved into the door.";

                ActionButton1.Show();
                ActionButton1.Text = "Living Room";
                ActionButton2.Show();
                ActionButton2.Text = "Hallway";
                ActionButton3.Show();
                ActionButton3.Text = "Sink";

                ActionButton1.Click += Entry;
                ActionButton2.Click += GoRight;
                ActionButton3.Click += SinkOff;

            }
            textScroll.Start();
        }

        private void Sink(object sender, EventArgs e)
        {
            worldBuildLabel.Text = "You walk over to the sink and turn off the water. You watch as the water goes down the drain and you " +
                "notice a key at the bottom of the sink. The key looks strange and is broken on the handle.";

            skey = true;
            sinkOff = true;
            itemLabel.Show();
            itemLabel.ForeColor = Color.Lime;
            text = worldBuildLabel.Text;
            len = text.Length;

            
            itemFade.Start();
            itemLabel.Text = "+ Strange Key";
            

            nextForm.Visible = false;
            codeTextBox.Visible = false;
            textScroll.Start();

            itemLabel.Hide();

            ActionButton1.Hide();
            ActionButton2.Show();
            ActionButton2.Text = "Back";
            ActionButton3.Hide();


            ActionButton2.Click += Kitchen;
        }

        private void SinkOff(object sender, EventArgs e)
        {
            worldBuildLabel.Text = "You walk over to look at the sink. I guess you really like that sink.";

            
            text = worldBuildLabel.Text;
            len = text.Length;

            nextForm.Visible = false;
            codeTextBox.Visible = false;
            textScroll.Start();

            itemLabel.Hide();

            ActionButton1.Hide();
            ActionButton2.Show();
            ActionButton2.Text = "Back";
            ActionButton3.Hide();


            ActionButton2.Click += Kitchen;
        }

        
        //--------------------------------End Kitchen---------------------------------------------------//

        //--------------------------------End Hallway---------------------------------------------------//
        //-----------------------------------------End Story----------------------------------------------------//
        //-----------------------------------------Visual Elements----------------------------------------------------//
        private void itemFade_Tick(object sender, EventArgs e)
        {
            int[] fadeRGB = new int[3];
            int [] targetColor = { 0, 0, 0 };

            fadeRGB[0] = itemLabel.ForeColor.R;
            fadeRGB[1] = itemLabel.ForeColor.G;
            fadeRGB[2] = itemLabel.ForeColor.B;


            //slowly lowering the RGB value of the color to create the fade effect
            if (fadeRGB[0] > targetColor[0])
            {
                fadeRGB[0]--;
            }
            else if (fadeRGB[0] < targetColor[0])
            {
                fadeRGB[0]++;
            }
            if (fadeRGB[1] > targetColor[1])
            {
                fadeRGB[1]--;
            }
            else if (fadeRGB[1] < targetColor[1])
            {
                fadeRGB[1]++;
            }
            if (fadeRGB[2] > targetColor[2])
            {
                fadeRGB[2]--;
            }
            else if (fadeRGB[2] < targetColor[2])
            {
                fadeRGB[2]++;
            }
            if (fadeRGB[0] == targetColor[0] && fadeRGB[1] == targetColor[1] && fadeRGB[2] == targetColor[2])
            {
                itemFade.Stop();
            }

            itemLabel.ForeColor = Color.FromArgb(fadeRGB[0], fadeRGB[1], fadeRGB[2]);
            
        }

        private void textScroll_Tick(object sender, EventArgs e)
        {
            worldBuildLabel.Text = text.Substring(0, counter);

            counter++;

            if (counter > len)
            {
                worldBuildLabel.Show();
                textScroll.Stop(); //stop of timer

            }

        }

        private void worldBuild_Click(object sender, EventArgs e)
        {
            try
            {
                textScroll.Interval -= 10;
            }
            catch (ArgumentOutOfRangeException)
            {
                textScroll.Interval = 1;
            }
        }
        //-----------------------------------------End Visual-------------------------------------------------//
        //-----------------------------------------Button Clicks for Menu's-------------------------------------------------//


        private void ItemButton_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory(flash,skey,brkey);
            inventory.ShowDialog();
            inventory.TopMost = true;
            
           
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            titleForm tF = new titleForm();
            tF.Show();

            Close();

        }


        private void nextForm_Click(object sender, EventArgs e)
        {
            getUp();
        }

        //-----------------------------------------End Menu Buttons-------------------------------------------------//
    }//end worldbuild
}//end namespace
