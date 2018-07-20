fin = open('input.txt', 'r')
fout = open('ip71_kozyriev_05_output.txt', 'w')

#reading data from file and adding to array
n = int(fin.readline())
A = [int(fin.readline()) for line in range(n)]

#initializing heaps
minHeap, maxHeap = [A[0]], []

#adding first element to min heap and then run algorythm
fout.write(str(minHeap[0]) + '\n')

def max_heapify(A, i):
    left = 2 * i + 1
    right = 2 * i + 2
    largest = i
    if left < len(A) and A[left] > A[largest]: largest = left
    if right < len(A) and A[right] > A[largest]: largest = right
    if largest != i:
        A[i], A[largest] = A[largest], A[i]
        max_heapify(A, largest)

def build_max_heap(A):
    for i in range(len(A) // 2, -1, -1): max_heapify(A, i)

def min_heapify(A, i):
    left = 2 * i + 1
    right = 2 * i + 2
    smallest = i
    if left < len(A) and A[left] < A[smallest]: smallest = left
    if right < len(A) and A[right] < A[smallest]: smallest = right
    if smallest != i:
        A[i], A[smallest] = A[smallest], A[i]
        min_heapify(A, smallest)

def build_min_heap(A):
    for i in range(len(A) // 2, -1, -1): min_heapify(A, i)

for i in range(1, n):
    if A[i] >= minHeap[0]:
        minHeap.append(A[i])
        build_min_heap(minHeap)
        build_max_heap(maxHeap)
    else:
        maxHeap.append(A[i])
        build_min_heap(minHeap)
        build_max_heap(maxHeap)

    if len(minHeap) - len(maxHeap) >= 2:
        buff = minHeap.pop(0)
        maxHeap.insert(0, buff)
        build_min_heap(minHeap)
        build_max_heap(maxHeap)

    if len(maxHeap) - len(minHeap) >= 2:
        buff = maxHeap.pop(0)
        minHeap.insert(0, buff)
        build_min_heap(minHeap)
        build_max_heap(maxHeap)

    if len(maxHeap) == len(minHeap):
        fout.write('{0} {1}\n'.format(maxHeap[0], minHeap[0]))
    elif len(maxHeap) > len(minHeap):
        fout.write('{0}\n'.format(maxHeap[0]))
    else:
        fout.write('{0}\n'.format(minHeap[0]))
