import math

#reading data from file
fin = open('input.txt', 'r')
fout = open(' ip71_kozyriev_07_output.txt', 'w')

n = int(fin.readline())
data = []
matrix = []
for i in range (0, n):
    buff = fin.readline().rstrip().split(' ')
    data.append([int(buff[0]),int(buff[1])])

for i in data:
    row = []
    x1 = i[0]
    y1 = i[1]
    for j in data:
        x2 = j[0]
        y2 = j[1]
        length = math.sqrt((x2-x1)**2 + (y2 - y1)**2)
        if length == 0.0:
            row.append(math.inf)
        else:
            row.append(length)
    matrix.append(row)

visited = []
visited.append(0)
valid = [True] * len(matrix[0])
valid[0] = False
to_begin = []

for i in matrix:
    to_begin.append(i[0])
way_length = 0

def greed(point):
    global way_length
    for i in matrix[point]:
        opt = min(matrix[point])
        index = matrix[point].index(min(matrix[point]))
        matrix[point][index] = math.inf
        if valid[index] == True:
            if opt != math.inf:
                way_length += opt
            valid[index] = False
            visited.append(index)
            greed(index)


greed(0)
way_length += to_begin[visited[len(visited)-1]]

fout.write(str(way_length) + '\n')

for i in visited:
    fout.write(str(i) + ' ')
