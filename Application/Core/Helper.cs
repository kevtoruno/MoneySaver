﻿using AutoMapper;
using Service.Core.DataModel;
using Service.Core.Dtos.LoansDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Core
{
    public static class Helper
    {
        public static string CordobaFormat(this decimal amount)
        {
            return "C$ "+ String.Format("{0:#,##0.00}", amount);
        }

        public static string RemoveAllWhiteSpaces(this string input)
        {
            return new string(input.ToCharArray()
                .Where(c => !Char.IsWhiteSpace(c))
                .ToArray());
        }

        public static void SendErrorToText(Exception ex)  
        {  
            var line = Environment.NewLine + Environment.NewLine;  
  
            string ErrorlineNo = ex.StackTrace.Substring(ex.StackTrace.Length - 7, 7);  
            string Errormsg = ex.GetType().Name.ToString();  
            string extype = ex.GetType().ToString();  
            string ErrorLocation = ex.Message.ToString();  
  
            try  
            {  
                string filepath = "ErrorsLog/";  //Text File Path
  
                if (!Directory.Exists(filepath))  
                {  
                    Directory.CreateDirectory(filepath);  
                }  
                filepath = filepath + DateTime.Today.ToString("dd-MM-yy") + ".txt";   //Text File Name
                if (!File.Exists(filepath))  
                {  
                    File.Create(filepath).Dispose();  
                }  
                using (StreamWriter sw = File.AppendText(filepath))  
                {  
                    string error = "Log Written Date:" + " " + DateTime.Now.ToString() + line + "Error Line No :" + " " + ErrorlineNo + line + "Error Message:" + " " + Errormsg + line + "Exception Type:" + " " + extype + line + "Error Location :" + " " + ErrorLocation + line;  
                    sw.WriteLine("-----------Exception Details on " + " " + DateTime.Now.ToString() + "-----------------");  
                    sw.WriteLine("-------------------------------------------------------------------------------------");  
                    sw.WriteLine(line);  
                    sw.WriteLine(error);  
                    sw.WriteLine("--------------------------------*End*------------------------------------------");  
                    sw.WriteLine(line);  
                    sw.Flush();  
                    sw.Close();  
                }  
            }  
            catch (Exception e)  
            {  
                e.ToString();  
            }  
        }
        
        public static IMappingExpression<TSource, TDestination> MapOnlyIfChanged<TSource, TDestination>(this IMappingExpression<TSource, TDestination> map)
        {
            map.ForAllMembers(source =>
            {
                source.Condition((sourceObject, destObject, sourceProperty, destProperty) =>
                {
                    if (sourceProperty == null)
                        return !(destProperty == null);
                    return !sourceProperty.Equals(destProperty);
                });
            });
            return map;
        }
    }
}
