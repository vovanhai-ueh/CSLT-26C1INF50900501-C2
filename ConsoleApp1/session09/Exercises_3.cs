using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_26C1INF50900501_C2.session09 {
    internal class Exercises_3 {
        /**
         * The X company has 3 working groups; 
         *      group 1 has 5 members, 
         *      group 2 has 3 members, 
         *      and group 3 has 6 members. 
         * The data stored for each member has an ID number, full name, and completed tasks. 
         * An ID identifies each member.
         */
        public static void Main1(string[] args) {
            string[][,] groups = CreateGroups();
            string csv = PrintInfos(groups);
            Console.WriteLine(csv);
            EX03.WriteText2File("output.csv", csv);

            /*Console.Write("Ban tim nhan vien co ID: ");
            int id = int.Parse(Console.ReadLine());
            PrintInfos(groups, id);*/

            //PrintEmpWithMaxCompletedTasks(groups);
            /* string[,] empWithMaxCompletedTasks = SearchEmpWithMaxCompletedTasks(groups);
             Console.WriteLine($"Employee with max completed tasks: " +
                 $"ID: {empWithMaxCompletedTasks[0, 0]}," +
                 $" Name: {empWithMaxCompletedTasks[0, 1]}, " +
                 $"Completed Tasks: {empWithMaxCompletedTasks[0, 2]}");*/
        }

        private static string[][,] CreateGroups() {
            string[][,] groups = new string[3][,];
            groups[0] = new string[5, 3]{
               {"1001", "Nguyen Van A", "15"},
               {"1002", "Tran Thi B", "8"},
               {"1003", "Le Van C", "12"},
               {"1004", "Pham Thi D", "9"},
               {"1005", "Hoang Van E", "11"}
           };
            groups[1] = new string[3, 3] {
              {"2001", "Nguyen Van F", "7"},
               {"2002", "Tran Thi G", "6"},
               {"2003", "Le Van H", "5"}
           };
            groups[2] = new string[6, 3]{
                {"3001", "Nguyen Van I", "10"},
                {"3002", "Tran Thi J", "8"},
                {"3003", "Le Van K", "13"},
                {"3004", "Pham Thi L", "9"},
                {"3005", "Hoang Van M", "11"},
                {"3006", "Vo Thi N", "17"}
            };
            return groups;
        }
        /// <summary>
        /// Prints the information of each group and its members.
        /// </summary>
        /// <param name="groups"></param>
        public static string PrintInfos(string[][,] groups) {
            /*foreach (string[,] row in groups) {
                for (int i = 0; i < row.GetLength(0); i++) {
                    for (int j = 0; j < row.GetLength(1); j++) {
                        Console.Write($"{row[i, j]}\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("-------------");
            }*/
            //phiên bản convert sang csv
            string csv = "";
            foreach (string[,] row in groups) {
                for (int i = 0; i < row.GetLength(0); i++) {
                    for (int j = 0; j < row.GetLength(1); j++) {
                        csv += row[i, j]+",";
                    }
                    //csv = csv.TrimEnd(','); // Remove the trailing comma
                    csv += "\n"; // Add a new line after each row
                }
            }
            return csv;

            //TODO: suy nghĩ chuyển dữ liệu sang dạng JSON/XML 
        }

        /// <summary>
        /// Prints the information of a specific member identified by their ID.
        /// </summary>
        /// <param name="groups">The array of groups containing member information.</param>
        /// <param name="id">The ID of the member to print information for.</param>
        public static void PrintInfos(string[][,] groups, int id) {
            bool found = false;//giả sử chưa tìm thấy
            foreach (string[,] row in groups) {
                for (int i = 0; i < row.GetLength(0); i++) {
                    if (int.Parse(row[i, 0]) == id) {
                        Console.WriteLine($"ID: {row[i, 0]}");
                        Console.WriteLine($"Name: {row[i, 1]}");
                        Console.WriteLine($"Completed Tasks: {row[i, 2]}");
                        found = true;//đã tìm thấy
                        break;
                    }
                }
            }
            if (!found) {
                Console.WriteLine("Member not found.");
            }
        }

        /// <summary>
        /// Print the member with the highest number of completed tasks
        /// </summary>
        /// <param name="groups">The array of groups containing member information.</param>
        public static void PrintEmpWithMaxCompletedTasks(string[][,] groups) {
            int maxCompletedTasks = -1;//giả sử chưa có ai hoàn thành nhiệm vụ
            foreach (string[,] row in groups) {
                for (int i = 0; i < row.GetLength(0); i++) {
                    int completedTasks = int.Parse(row[i, 2]);
                    if (completedTasks > maxCompletedTasks) {
                        maxCompletedTasks = completedTasks;
                    }
                }
            }
            Console.WriteLine($"Maximum completed tasks: {maxCompletedTasks}");
        }

        public static string [,] SearchEmpWithMaxCompletedTasks(string[][,] groups) {
            int maxCompletedTasks = -1;//giả sử chưa có ai hoàn thành nhiệm vụ
            string[,] empWithMaxCompletedTasks = new string[1, 3];
            foreach (string[,] row in groups) {
                for (int i = 0; i < row.GetLength(0); i++) {
                    int completedTasks = int.Parse(row[i, 2]);
                    if (completedTasks > maxCompletedTasks) {
                        maxCompletedTasks = completedTasks;
                        //gán thông tin của nhân viên có số nhiệm vụ hoàn thành nhiều nhất vào mảng empWithMaxCompletedTasks
                        empWithMaxCompletedTasks[0, 0] = row[i, 0];
                        empWithMaxCompletedTasks[0, 1] = row[i, 1];
                        empWithMaxCompletedTasks[0, 2] = row[i, 2];
                    }
                }
            }
            return empWithMaxCompletedTasks;
        }
    }
}
