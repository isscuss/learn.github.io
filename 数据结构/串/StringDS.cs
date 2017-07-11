using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 串
{
    class StringDS
    {
        private char[] data;
        public StringDS(char[] array)
        {
            data = new char[array.Length];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = array[i];
            }
        }
        public StringDS(string str)
        {
            data = new char[str.Length];
            for (int i = 0; i < data.Length; i++) 
            {
                data[i] = str[i];
            }
        }
        //根据索引访问字符的索引器
        public char this[int index]
        {
            get { return data[index]; }
        }
        public int GetLength() 
        {
            return data.Length;
        }
        //比较两个字符，如果一样就返回0；当前字符小于s，返回-1；当前字符大于s，返回1
        public int Compare(StringDS s)
        {
            int len = this.GetLength() < s.GetLength() ? this.GetLength() : s.GetLength();//两个字符串中，取更小字符串的长度
            int index = -1;//字符串不等时，索引位置
            for (int i = 0; i < len; i++) 
            {
                if (this[i] != s[i])
                {
                    index = i;
                    break;
                }
            }
            if (index != -1)
            {
                if (this[index] > s[index])
                {
                    return 1;
                }
                else 
                {
                    return -1;
                }
            }
            else 
            {
                if (this.GetLength() == s.GetLength())
                {
                    return 0;
                }
                else 
                {
                    if (this.GetLength() > s.GetLength())
                    {
                        return 1;
                    }
                    else 
                    {
                        return -1;
                    }
                }
            }

        }
        public StringDS SubString(int index,int length)//求字符串的子串，根据索引和子串长度
        {
            char[] newData = new char[length];
            for (int i = index; i < index + length; i++)
            {
                newData[i - index] = data[i];
            }
            return new StringDS(newData);
        }
        public static StringDS Concat(StringDS s1, StringDS s2)//连接两个s1,s2字符串
        {
            char[] newData = new char[s1.GetLength() + s2.GetLength()];
            for (int i = 0; i < s1.GetLength(); i++) 
            {
                newData[i] = s1[i];
            }
            for (int i = s1.GetLength(); i < newData.Length; i++)
            {
                newData[i] = s2[i - s1.GetLength()];
            }
            return new StringDS(newData);
        }
        public int IndexOf(StringDS s)//检查s字符串是否是当前字符串的子串
        {
            for (int i = 0; i <= this.GetLength() - s.GetLength(); i++)
            {
                bool isEqual = true;
                for (int j = i; j < i + s.GetLength(); j++) 
                {
                    if (this[j] != s[j - i])
                    {
                        isEqual = false;
                    }
                }
                if (isEqual)
                {
                    return i;
                }
                else 
                {
                    continue;
                }
            }
            return -1;
        }
        public string ToString() 
        {
            return new string(data);
        }
    }
}
