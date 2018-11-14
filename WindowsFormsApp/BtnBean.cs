﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    class BtnBean
    {
        Form form;
        string name;
        string txt;
        int sizeX;
        int sizeY;
        int pX;
        int pY;
        public EventHandler eh;
        public BtnBean(Form form, string name, string txt, int sizeX, int sizeY, int pX, int pY, EventHandler eh)
        {
            this.form = form;
            this.name = name;
            this.txt = txt;
            this.sizeX = sizeX;
            this.sizeY = sizeY;
            this.pX = pX;
            this.pY = pY;
            this.eh = eh;
        }

        public Form Form
        {
            get
            {
                return form;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public string Txt
        {
            get
            {
                return txt;
            }
        }
        public int SizeX
        {
            get
            {
                return sizeX;
            }
        }
        public int SizeY
        {
            get
            {
                return sizeY;
            }
        }
        public int PX
        {
            get
            {
                return pX;
            }
        }
        public int PY
        {
            get
            {
                return pY;
            }
        }
    }
}
