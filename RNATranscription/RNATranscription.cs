using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {
        public static string ToRna(string nucleotide)
        {    StringBuilder st=new StringBuilder(nucleotide);
         Dictionary<char, char> My_dict =   
                     new Dictionary<char, char>();
                     My_dict['G']='C';
                     My_dict['C']='G';
                     My_dict['A']='U';
                     My_dict['T']='A';
                     for(int i=0;i<st.Length;i++)
                     st[i]=My_dict[st[i]];
                     return st.ToString();

}

       public static void Main(string[] args)
            {
            
            }

                
            
    }
}
