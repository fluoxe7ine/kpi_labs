import random

A = []

def quicksort(a):
    if len(a)<=1:
        return a
    smaller, equal, larger = [],[],[]
    pivot = a[len(a)-1]

    for x in a:
        if x < pivot:
            smaller.append(x)
        elif x==pivot:
            equal.append(x)
        else:
            larger.append(x)
    return quicksort(smaller)+equal+quicksort(larger)

#shellsort function
def shellsort(a):
    sublist_len = len(a) // 2
    while sublist_len > 0:
      for start in range(sublist_len):
        gapInsertionSort(a,start,sublist_len)
      sublist_len = sublist_len // 2

def gapInsertionSort(a, start, gap):
    for i in range(start + gap, len(a), gap):
        curr_val = a[i]
        pos = i
        while pos >= gap and a[pos-gap] > curr_val:
            a[pos] = a[pos-gap]
            pos = pos - gap
        a[pos] = curr_val

#generating sorted list
for i in range(0,100,10):
    A.append(i)

#generating random number bigger than left and smaller than right element
for i in range(0, len(A) - 1):
    print (A[i], A[i+1])
    A.append(random.randint(A[i] + 1, A[i+1] - 1))

B = A #copying list A
A = quicksort(A)
shellsort(B)

print(A)
print(B)
