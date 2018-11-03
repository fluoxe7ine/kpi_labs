    using System;
    using System.Numerics;

    namespace lab2_c
    {
        abstract class M {
            public abstract void fillMatrix();
            public abstract void showMatrix();
            public abstract void Kramer();
            public abstract void Podstanovka();
            public abstract void Substitute();
        }
        class Matrix : M
        {
            private int m;
            private int n;
            public double[,] matrix;
            public Matrix (int width, int height) {
                m = width;
                n = height;
                matrix = new double[m, n];
            }

            public override void fillMatrix () {
                // Random rand = new Random();
                for (int i = 0;  i < m; i++) {
                    for (int j = 0; j < n; j++) {
                        Random rand = new Random();
                        matrix[i,j] = rand.Next(-10,10); 
                    }
                }
            }

            public override void showMatrix () {
                // Random rand = new Random();
                for (int i = 0;  i < m; i++) {
                    for (int j = 0; j < n; j++) {
                        // Random rand = new Random();
                        Console.Write(matrix[i,j] + " ");
                    }
                    Console.WriteLine();
                }
            }

            public override void Kramer () {
                double det_main;
                double det_1;
                double det_2;
                // double det_3;
                det_main = matrix[0,0] * matrix[1,1] - matrix[0,1] * matrix[1,0];
                det_1 = matrix[0,2] * matrix[1,1] - matrix[0,1] * matrix[1,2];
                det_2 = matrix[0,0] * matrix[1,2] - matrix[0,2] * matrix[1,0];
                
                
                Console.WriteLine("x1: " + det_1/det_main);
                Console.WriteLine("x2: " + det_2/det_main);
                
                Console.WriteLine("x1: " + det_1/det_main);
                Console.WriteLine("x2: " + det_2/det_main);
            }

            public override void Podstanovka(){

            }

            public override void Substitute(){
                double koef1;
                double koef2;
                koef1 = (matrix[0,0] * matrix[1,0] * -1) / matrix[0,0];
                koef2 = (matrix[0,0] * matrix[1,0]) / matrix[1,0];
                // Console.WriteLine(koef1); 
                // Console.WriteLine(koef2);
                for (int i = 0; i < 1; i++){
                    for (int j = 0; j < 2; j++){
                        matrix[i,j] = matrix[i,j] * koef1;
                    }
                }

                for (int i = 1; i < 2; i++){
                    for (int j = 0; j < 2; j++){
                        matrix[i,j] = matrix[i,j] * koef2;
                    }
                }

                double x2;
                double x1;
                x2 = (matrix[0,2] + matrix[1,2]) /  (matrix[0,1] + matrix[1,1]);
                /// (matrix[0,1]);
                x1 = (matrix[0,2] + matrix[1,2] - x2) / matrix[0,0] / matrix[1,0];
                // showMatrix();
                // Console.WriteLine("x1: " + x1);
                // Console.WriteLine("x2: " + x2);

            }
            
        }
    }
