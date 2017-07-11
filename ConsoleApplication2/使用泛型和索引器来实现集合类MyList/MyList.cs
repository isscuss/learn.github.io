using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 使用泛型和索引器来实现集合类MyList
{
    class MyList<T> where T:IComparable//这时一个泛型类，用来处理任何类型的数据,继承自compareable，方便处理排序
    {
        private T[] array;
        private int count=0;//获取当前添加添加元素的个数
        public MyList(int size)//构造函数，处理有数组长度的
        {
            if (size >= 0)
            { 
                array=new T[size];
            }
        }
        public MyList()//构造函数，处理初始数组为0的情况
        {
            array = new T[0];
        }
        public int Capacity//获取数组长度的方法
        {
            get { return array.Length; }
        }
        public int Count//获取添加元素个数的方法
        {
            get { return count; }
        }
        public void Add(T item)//添加元素的方法
        {
            if (Count == Capacity)
            {
                if (Capacity == 0)
                {
                    array = new T[4];//如果长度为0，就新建一个长度为4的数组
                }
                else
                {
                    var newArray = new T[Capacity * 2];//新建一个2倍长度的数组
                    Array.Copy(array, newArray, Count);//把array原来的值复制到newArray中,个数为Count
                    array = newArray;//原来的array数组在堆中失去了地址，会被gc清除
                }
            }
            array[Count] = item;
            count++;//元素个数自增
        }
        public T GetItem(int index)//根据索引查找元素
        {
            if (index >= 0 && index <= count - 1)//判断索引是否合法
            {
                return array[index];
            }
            else
            {
                throw new Exception("索引超出范围了");//抛出异常
            }
        }
        public T this[int index]//设置索引器,通过get和set方法咯
        {
            get
            {
                return GetItem(index);
            }
            set//通过索引器修改值
            {
                if (index >= 0 && index <= count - 1)
                {
                    array[index] = value;
                }
                else
                {
                    throw new Exception("索引超出范围咯");
                }
            }
        }
        public void Insert(int index, T item)//插入方法
        {
            if (Count == Capacity)//判断是否需要扩容
            {
                var newArray = new T[Capacity * 2];//创建新数组
                Array.Copy(array, newArray, count);
                array = newArray;//换一个新数组咯
            }
            for (int i = count - 1; i >= index; i--)//从数组后面开始向前遍历
            {
                array[i + 1] = array[i];
            }
            array[index] = item;//搞定完复杂东西，终于可以赋值咯
            count++;
        }
        public void RemoveAt(int index)//移除数组中的一个数据
        {
            if (index >= 0 && index <= count - 1)
            {
                for (int i = index + 1; i < count; i++)
                {
                    array[i - 1] = array[i];

                }
                count--;
            }
            else
            {
                throw new Exception("超出范围咯");
            }
        }
        public int IndexOf(T item)//正序检索item的所在索引位置
        {
            for (int i = 0; i < count; i++)
            {
                if (array[i].Equals(item))//item是泛型，所以不能简单地通过布尔运算符进行比较
                {
                    return i;
                }
            }
            return -1;
        }
        public int LastIndexOf(T item)//逆序检索(逻辑基本相同)
        {
            for (int i = count - 1; i >= 0; i--)
            {
                if(array[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }
        public void Sort()//经典冒泡排序
        {
            for (int j = 0; j < count - 1; j++)
            {
                for (int i = 0; i < count - 1 - j; i++)//小优化了一下
                {
                    if (array[i].CompareTo(array[i + 1]) > 0)//隐藏含义是array[i]>array[i+1]的意思
                    {
                        T temp = array[i];//设置一个临时值
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }
             
        }
    }
}
