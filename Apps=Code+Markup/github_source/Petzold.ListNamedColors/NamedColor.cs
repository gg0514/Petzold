﻿using System.Reflection;
using System.Windows.Media;

namespace Petzold.ListNamedColors
{
    public class NamedColor
    {
        static NamedColor[] nclrs;
        Color clr;
        string str;

        // Static 생성자
        static NamedColor()
        {
            PropertyInfo[] props = typeof(Colors).GetProperties();
            nclrs = new NamedColor[props.Length];

            for (int i = 0; i < props.Length; i++)
                nclrs[i] = new NamedColor(props[i].Name, (Color)props[i].GetValue(null, null));
        }

        // private 생성자
        private NamedColor(string str, Color clr)
        {
            this.str = str;
            this.clr = clr;
        }

        // Static 읽기 전용 속성
        public static NamedColor[] All
        {
            get { return nclrs; }
        }

        // 읽기 전용 속성
        public Color Color
        {
            get
            {
                return clr;
            }
        }

        public string Name
        {
            get
            {
                string strSpaced = str[0].ToString();

                for (int i = 1; i < str.Length; i++)
                {
                    strSpaced += (char.IsUpper(str[i]) ? " " : "") + str[i];
                }

                return strSpaced;
            }
        }

        // ToString 메서드 오버라이딩
        //public override string ToString()
        //{
        //    return str;
        //}
    }
}
