    using System;
    using System.Numerics;

    namespace lab2_c
    {
        class Matrix
        {
            private int m;
            private int n;
            public Fraction[,] matrix;
            public Matrix (int width, int height) {
                if (width <= 0 || height <= 0) throw new InitException("Invalid initialize data exception");
                m = width;
                n = height;
                matrix = new Fraction[m, n];
            }

            public void fillMatrix () {
                Random rand = new Random();
                for (int i = 0;  i < m; i++) {
                    for (int j = 0; j < n; j++) {
                        int numerator = rand.Next(-10, 50);
                        int denuminator = rand.Next(-30, 100);
                        matrix[i,j] = new Fraction($"{numerator}/{denuminator}"); 
                    }
                }
            }

            public void showMatrix () {
                for (int i = 0;  i < m; i++) {
                    for (int j = 0; j < n; j++) {
                        Console.Write($"{matrix[i,j].fract_value} ");
                    }
                    Console.WriteLine();
                }
            }
            
            public static Matrix operator ~(Matrix m) {
            for (int i = 0; i < m.m; i++) {
                for (int j = 0; j < m.n; j++) {
                    Console.Write($"{m.matrix[i,j].fract_value} ");
                }
                Console.WriteLine();
            }
            return m;
            } 
            public static Matrix operator +(Matrix m1, Matrix m2) {
                if (m1.m != m2.m || m1.n != m2.n) throw new ProblemException("Matrix should have equal size");
                Matrix result = new Matrix(m1.m, m1.n);
                for (int i = 0;  i < m1.m; i++) {
                    for (int j = 0; j < m1.n; j++) {
                        result.matrix[i,j] = m1.matrix[i,j] + m2.matrix[i,j];
                    }
                }
                return result;
            }

            public static Matrix operator +(Matrix m1, int m2) {
                Matrix result = new Matrix(m1.m, m1.n);
                for (int i = 0;  i < m1.m; i++) {
                    for (int j = 0; j < m1.n; j++) {
                        result.matrix[i,j] = m1.matrix[i,j] + m2;
                    }
                }
                return result;
            }

            public static Matrix operator +(int m1, Matrix m2) {
                Matrix result = new Matrix(m2.m, m2.n);
                for (int i = 0;  i < m2.m; i++) {
                    for (int j = 0; j < m2.n; j++) {
                        result.matrix[i,j] = m1 + m2.matrix[i,j];
                    }
                }
                return result;
            }

            public static Matrix operator +(Matrix m1, Bignum_arithmetic m2) {
                Matrix result = new Matrix(m1.m, m1.n);
                for (int i = 0;  i < m1.m; i++) {
                    for (int j = 0; j < m1.n; j++) {
                        result.matrix[i,j] = m1.matrix[i,j] + m2;
                    }
                }
                return result;
            }

            public static Matrix operator +(Bignum_arithmetic m1, Matrix m2) {
                Matrix result = new Matrix(m2.m, m2.n);
                for (int i = 0;  i < m2.m; i++) {
                    for (int j = 0; j < m2.n; j++) {
                        result.matrix[i,j] = m1 + m2.matrix[i,j];
                    }
                }
                return result;
            }

            public static Matrix operator +(Matrix m1, Fraction m2) {
                Matrix result = new Matrix(m1.m, m1.n);
                for (int i = 0;  i < m1.m; i++) {
                    for (int j = 0; j < m1.n; j++) {
                        result.matrix[i,j] = m1.matrix[i,j] + m2;
                    }
                }
                return result;
            }

            public static Matrix operator +(Fraction m1, Matrix m2) {
                Matrix result = new Matrix(m2.m, m2.n);
                for (int i = 0;  i < m2.m; i++) {
                    for (int j = 0; j < m2.n; j++) {
                        result.matrix[i,j] = m1 + m2.matrix[i,j];
                    }
                }
                return result;
            }

            public static Matrix operator -(Matrix m1, Matrix m2) {
                if (m1.m != m2.m || m1.n != m2.n) throw new ProblemException("Matrix should have equal size");
                Matrix result = new Matrix(m1.m, m1.n);
                for (int i = 0;  i < m1.m; i++) {
                    for (int j = 0; j < m1.n; j++) {
                        result.matrix[i,j] = m1.matrix[i,j] - m2.matrix[i,j];
                    }
                }
                return result;
            }
            public static Matrix operator -(Matrix m1, int m2) {
                Matrix result = new Matrix(m1.m, m1.n);
                for (int i = 0;  i < m1.m; i++) {
                    for (int j = 0; j < m1.n; j++) {
                        result.matrix[i,j] = m1.matrix[i,j] - m2;
                    }
                }
                return result;
            }

            public static Matrix operator -(int m1, Matrix m2) {
                Matrix result = new Matrix(m2.m, m2.n);
                for (int i = 0;  i < m2.m; i++) {
                    for (int j = 0; j < m2.n; j++) {
                        result.matrix[i,j] = m1 - m2.matrix[i,j];
                    }
                }
                return result;
            }

            public static Matrix operator -(Matrix m1, Bignum_arithmetic m2) {
                Matrix result = new Matrix(m1.m, m1.n);
                for (int i = 0;  i < m1.m; i++) {
                    for (int j = 0; j < m1.n; j++) {
                        result.matrix[i,j] = m1.matrix[i,j] - m2;
                    }
                }
                return result;
            }

            public static Matrix operator -(Bignum_arithmetic m1, Matrix m2) {
                Matrix result = new Matrix(m2.m, m2.n);
                for (int i = 0;  i < m2.m; i++) {
                    for (int j = 0; j < m2.n; j++) {
                        result.matrix[i,j] = m1 - m2.matrix[i,j];
                    }
                }
                return result;
            }

            public static Matrix operator -(Matrix m1, Fraction m2) {
                Matrix result = new Matrix(m1.m, m1.n);
                for (int i = 0;  i < m1.m; i++) {
                    for (int j = 0; j < m1.n; j++) {
                        result.matrix[i,j] = m1.matrix[i,j] - m2;
                    }
                }
                return result;
            }

            public static Matrix operator -(Fraction m1, Matrix m2) {
                Matrix result = new Matrix(m2.m, m2.n);
                for (int i = 0;  i < m2.m; i++) {
                    for (int j = 0; j < m2.n; j++) {
                        result.matrix[i,j] = m1 - m2.matrix[i,j];
                    }
                }
                return result;
            }

            public static Matrix operator *(Matrix m1, Matrix m2) {
                if (m1.m != m2.n || m1.n != m2.m) throw new ProblemException("Invalid data for matrix multiplying");
                Matrix result = new Matrix(m1.m, m1.n);
                for (int i = 0;  i < m1.m; i++) {
                    for (int j = 0; j < m1.n; j++) {
                        result.matrix[i,j] = m1.matrix[i,j] * m2.matrix[i,j];
                    }
                }
                return result;
            }

            public static Matrix operator *(Matrix m1, int m2) {
                Matrix result = new Matrix(m1.m, m1.n);
                for (int i = 0;  i < m1.m; i++) {
                    for (int j = 0; j < m1.n; j++) {
                        result.matrix[i,j] = m1.matrix[i,j] * m2;
                    }
                }
                return result;
            }

            public static Matrix operator *(int m1, Matrix m2) {
                Matrix result = new Matrix(m2.m, m2.n);
                for (int i = 0;  i < m2.m; i++) {
                    for (int j = 0; j < m2.n; j++) {
                        result.matrix[i,j] = m1 * m2.matrix[i,j];
                    }
                }
                return result;
            }

            public static Matrix operator *(Matrix m1, Bignum_arithmetic m2) {
                Matrix result = new Matrix(m1.m, m1.n);
                for (int i = 0;  i < m1.m; i++) {
                    for (int j = 0; j < m1.n; j++) {
                        result.matrix[i,j] = m1.matrix[i,j] * m2;
                    }
                }
                return result;
            }

            public static Matrix operator *(Bignum_arithmetic m1, Matrix m2) {
                Matrix result = new Matrix(m2.m, m2.n);
                for (int i = 0;  i < m2.m; i++) {
                    for (int j = 0; j < m2.n; j++) {
                        result.matrix[i,j] = m1 * m2.matrix[i,j];
                    }
                }
                return result;
            }

            public static Matrix operator *(Matrix m1, Fraction m2) {
                Matrix result = new Matrix(m1.m, m1.n);
                for (int i = 0;  i < m1.m; i++) {
                    for (int j = 0; j < m1.n; j++) {
                        result.matrix[i,j] = m1.matrix[i,j] * m2;
                    }
                }
                return result;
            }

            public static Matrix operator *(Fraction m1, Matrix m2) {
                Matrix result = new Matrix(m2.m, m2.n);
                for (int i = 0;  i < m2.m; i++) {
                    for (int j = 0; j < m2.n; j++) {
                        result.matrix[i,j] = m1 * m2.matrix[i,j];
                    }
                }
                return result;
            }

            public static Matrix operator /(Matrix m1, Matrix m2) {
                if (m1.m != m2.m || m1.n != m2.n) throw new ProblemException("Matrix should have equal size");
                Matrix result = new Matrix(m1.m, m1.n);
                for (int i = 0;  i < m1.m; i++) {
                    for (int j = 0; j < m1.n; j++) {
                        result.matrix[i,j] = m1.matrix[i,j] / m2.matrix[i,j];
                    }
                }
                return result;
            }

            public static Matrix operator /(Matrix m1, int m2) {
                Matrix result = new Matrix(m1.m, m1.n);
                for (int i = 0;  i < m1.m; i++) {
                    for (int j = 0; j < m1.n; j++) {
                        result.matrix[i,j] = m1.matrix[i,j] / m2;
                    }
                }
                return result;
            }

            public static Matrix operator /(int m1, Matrix m2) {
                Matrix result = new Matrix(m2.m, m2.n);
                for (int i = 0;  i < m2.m; i++) {
                    for (int j = 0; j < m2.n; j++) {
                        result.matrix[i,j] = m1 / m2.matrix[i,j];
                    }
                }
                return result;
            }

            public static Matrix operator /(Matrix m1, Bignum_arithmetic m2) {
                Matrix result = new Matrix(m1.m, m1.n);
                for (int i = 0;  i < m1.m; i++) {
                    for (int j = 0; j < m1.n; j++) {
                        result.matrix[i,j] = m1.matrix[i,j] / m2;
                    }
                }
                return result;
            }

            public static Matrix operator /(Bignum_arithmetic m1, Matrix m2) {
                Matrix result = new Matrix(m2.m, m2.n);
                for (int i = 0;  i < m2.m; i++) {
                    for (int j = 0; j < m2.n; j++) {
                        result.matrix[i,j] = m1 / m2.matrix[i,j];
                    }
                }
                return result;
            }

            public static Matrix operator /(Matrix m1, Fraction m2) {
                Matrix result = new Matrix(m1.m, m1.n);
                for (int i = 0;  i < m1.m; i++) {
                    for (int j = 0; j < m1.n; j++) {
                        result.matrix[i,j] = m1.matrix[i,j] / m2;
                    }
                }
                return result;
            }

            public static Matrix operator /(Fraction m1, Matrix m2) {
                Matrix result = new Matrix(m2.m, m2.n);
                for (int i = 0;  i < m2.m; i++) {
                    for (int j = 0; j < m2.n; j++) {
                        result.matrix[i,j] = m1 / m2.matrix[i,j];
                    }
                }
                return result;
            }

            public static Matrix operator -(Matrix matrix) {
                for (int i = 0; i < matrix.m; i++) {
                    for (int j = 0; j < matrix.n; j++) {
                        matrix.matrix[i,j] = matrix.matrix[i,j] * -1;
                    }
                }
                return matrix;
            }

            public static Matrix operator !(Matrix matrix) {
                Matrix newMatrix = new Matrix(matrix.n, matrix.m);
                for (int i = 0; i < matrix.m; i++) {
                    for (int j = 0; j < matrix.n; j++) {
                        newMatrix.matrix[j,i] = matrix.matrix[i,j];
                    }
                }
                return newMatrix;
            }
        }
    }
