import math
import sys

param = int(sys.argv[1])

#reading data from file and adding to arrays
fin = open('input.txt', 'r')
fout = open('ip71_kozyriev_05_output.txt', 'w')
A = []
S = []

buff = fin.readline().split(' ')
n = int(buff[0])
m = int(buff[1])

for i in range(n):
    buff = int(fin.readline())
    A.append(buff)
for i in range(m):
    buff = int(fin.readline())
    S.append(buff)

if param == 1:
    #first
    def ChainedHashDiv(arr, el):
        k = el % len(arr)
        arr[k].append(el)

    def ChainedHashDivSearch(arr,el):
        k = el % len(arr)
        if el in arr[k]:
            return True
        else:
            return False

    def collisionCheckChainedDiv(hashArr):
        count = 0
        for i in hashArr:
            if len(i) > 1:
                count += 1
        fout.write(str(count) + '\n')

    def checkSumDiv(S, hashArr):
        visited = []
        for x in A:
            y = S - x
            if ChainedHashDivSearch(T1, y) == True and (S - y not in visited and y not in visited) :
                visited.append(y)
                fout.write(str(x) + ' ' + str(y) + '\n')
        if len(visited) == 0:
            fout.write('0 0\n')


    T1 = [[] for i in range(len(A)*3)]
    for i in range(len(A)):
        ChainedHashDiv(T1, A[i])

    collisionCheckChainedDiv(T1)
    for i in S:
        checkSumDiv(i, T1)
elif param == 2:
#second
    T2 = [[] for i in range(len(A) * 3)]

    def ChainedHashMult(arr, el):
        golden_number = 0.618034
        ka = el * golden_number
        k = math.floor((ka % 1) * len(arr))
        arr[k].append(el)

    for i in range(len(A)):
        ChainedHashMult(T2, A[i])

    def collisionCheckChainedMult(hashArr):
        count = 0
        for i in hashArr:
            if len(i) > 1:
                count += 1
        fout.write(str(count) + '\n')

    def ChainedHashMultSearch(arr,el):
        golden_number = 0.618034
        ka = el * golden_number
        k = math.floor((ka % 1) * len(arr))
        if el in arr[k]:
            return True
        else:
            return False

    def checkSumMult(S, hashArr):
        visited = []
        for x in A:
            y = S - x
            if ChainedHashMultSearch(T2, y) == True and (S - y not in visited and y not in visited) :
                visited.append(y)
                fout.write(str(x) + ' ' + str(y) + '\n')
        if len(visited) == 0:
            fout.write('0 0\n')

    collisionCheckChainedMult(T2)
    for i in S:
        checkSumMult(i, T2)

elif param == 3:
    T3 = [[] for i in range(len(A) * 3)]
    def linearHash(el):
        i = 0
        while i != len(T3):
            k = (el + i) % len(T3)
            if len(T3[k]) == 0:
                T3[k].append(el)
                break
            else:
                i += 1
    def linearSearch(el):
        i = 0
        while i != len(T3):
            k = (el + i) % len(T3)
            if el in T3[k]:
                return True
            else:
                i += 1
        return False

    def checkSumLinear(S):
        visited = []
        for x in A:
            y = S - x
            if linearSearch(y) == True and (S - y not in visited and y not in visited) :
                visited.append(y)
                fout.write(str(x) + ' ' + str(y) + '\n')
        if len(visited) == 0:
            fout.write('0 0\n')

    def collisionCheckLinear():
        buff = [[] for i in range(len(A) * 3)]
        count = 0
        for i in range(len(A)):
            k = A[i] % len(T3)
            buff[k].append(A[i])
        for i in buff:
            if len(i) > 1:
                count += 1
        fout.write(str(count) + '\n')

    collisionCheckLinear()
    for i in A:
        linearHash(i)
    for i in S:
        checkSumLinear(i)
elif param == 4:
    T4 = [[] for i in range(len(A)*3)]
    def quadrHash(el):
        i = 0
        while i != len(T4):
            k = (el + i + 2*i*i) % len(T4)
            if len(T4[k]) == 0:
                T4[k].append(el)
                break
            else:
                i += 1
    def quadrSearch(el):
        i = 0
        while i != len(T4):
            k = (el + i + 2*i*i) % len(T4)
            if el in T4[k]:
                return True
            else:
                i += 1
        return False

    def checkSumQuadr(S):
        visited = []
        for x in A:
            y = S - x
            if quadrSearch(y) == True and (S - y not in visited and y not in visited) :
                visited.append(y)
                fout.write(str(x) + ' ' + str(y) + '\n')
        if len(visited) == 0:
            fout.write('0 0\n')

    def collisionCheckQuadr():
        buff = [[] for i in range(len(A) * 3)]
        count = 0
        for i in range(len(A)):
            k = A[i] % len(T4)
            buff[k].append(A[i])
        for i in buff:
            if len(i) > 1:
                count += 1
        fout.write(str(count) + '\n')

    collisionCheckQuadr()
    for i in A:
        quadrHash(i)
    for i in S:
        checkSumQuadr(i)
elif param == 5:
    T5 = [[] for i in range(len(A)*3)]
    def DoubleHash(el):
        i = 0
        while i != len(T5):
            k = ((el % len(T5)) + i*(el % len(A))) % len(T5)
            if len(T5[k]) == 0:
                T5[k].append(el)
                break
            else:
                i += 1
    def DoubleSearch(el):
        i = 0
        while i != len(T5):
            k = ((el % len(T5)) + i*(el % len(A))) % len(T5)
            if el in T5[k]:
                return True
            else:
                i += 1
        return False

    def checkSumDouble(S):
        visited = []
        for x in A:
            y = S - x
            if DoubleSearch(y) == True and (S - y not in visited and y not in visited) :
                visited.append(y)
                fout.write(str(x) + ' ' + str(y) + '\n')
        if len(visited) == 0:
            fout.write('0 0\n')

    def collisionCheckDouble():
        buff = [[] for i in range(len(A) * 3)]
        count = 0
        for i in range(len(A)):
            k = A[i] % len(T5)
            buff[k].append(A[i])
        for i in buff:
            if len(i) > 1:
                count += 1
        fout.write(str(count) + '\n')

    collisionCheckDouble()
    for i in A:
        DoubleHash(i)
    for i in S:
        checkSumDouble(i)
else:
    print('Invalid input, try again')
