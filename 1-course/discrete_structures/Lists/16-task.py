import random

A = []
#quicksort function
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

#generating an array of random numbers
for i in range(0,100):
    A.append(random.randint(-99,99))

#deleting all negative numbers
i = 0
while i < len(A):
    if A[i] < 0:
        del A[i]
    else:
        i += 1

B = A; #copying array for Shell's sort

A = quicksort(A)
shellsort(B)
print(A)
print(B)
