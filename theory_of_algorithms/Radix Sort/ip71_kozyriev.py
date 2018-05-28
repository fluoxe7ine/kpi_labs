import random
import math

maxCount = int(input('Type max count of digits in number: '))
listSize = int(input('Type size of array: '))
arr = [random.randint(-1*(10**maxCount),10**maxCount) for i in range (0,listSize)]
print(arr)

def countingSort(arr, max_value, get_index):
    counts = [0] * max_value
    for a in arr:
        counts[get_index(a)] += 1
    for i, c in enumerate(counts):
        if i == 0:
            continue
        else:
            counts[i] += counts[i-1]
    for i, c in enumerate(counts[:-1]):
        if i == 0:
            counts[i] = 0
        counts[i+1] = c
    result = [None] * len(arr)
    for a in arr:
        index = counts[get_index(a)]
        result[index] = a
        counts[get_index(a)] += 1
    return result

def getDigit(n, d):
    for i in range(d-1):
        n //= 10
    return n % 10

def getIndex(n):
    i = 0
    while n > 0:
        n //= 10
        i += 1
    return i

def radixSort(arr, max_value):
    num_digits = getIndex(max_value)
    for d in range(num_digits):
        arr = countingSort(arr, max_value, lambda a: getDigit(a, d+1))
    return arr

sideNeg = [] #side arr for negative values
sidePos = [] #side arr for positive values

for i in arr:
    if i < 0:
        sideNeg.append(abs(i))
    else:
        sidePos.append(i)

if len(sideNeg) > 0:
    sideNeg = list(reversed(radixSort(sideNeg, max(sideNeg))))
if len(sidePos) > 0:
    sidePos = radixSort(sidePos,max(sidePos))

for i in range(0,len(sideNeg)):
    sideNeg[i] = sideNeg[i] * (-1)

arr = sideNeg + sidePos
print(arr)
