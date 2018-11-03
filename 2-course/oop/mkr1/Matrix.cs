    using System;
    using System.Numerics;

    namespace lab2_c
    {
        class Matrix
        {
            public int[,] matrix;
            public Matrix(){
                for (int i = 0; i < 2; i++) {
                    for (int j = 0; j < 2; j++) {
                        this.matrix[i, j] = 1;
                    }
                }
            }
        }
    }
