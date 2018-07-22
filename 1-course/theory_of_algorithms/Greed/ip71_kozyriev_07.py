import math

#reading data from file
fin, fout = open('input.txt', 'r'), open(' ip71_kozyriev_07_output.txt', 'w')
data = [[int(line.rstrip().split(' ')[0]), int(line.rstrip().split(' ')[1])] for line in list(fin)[1:]]

matrix = []
for i in data:
    row = []
    x1, y1 = i[0], i[1]
    for j in data:
        x2, y2 = j[0], j[1]
        length = math.sqrt((x2-x1)**2 + (y2 - y1)**2)
        if length == 0.0: row.append(math.inf)
        else: row.append(length)
    matrix.append(row)

visited = [0]
valid, valid[0] = [True] * len(matrix[0]), False
to_begin = [i[0] for i in matrix]

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
way_length += to_begin[visited[-1]]
fout.write('{0}\n'.format(way_length))

for i in visited:
    fout.write('{0} '.format(i))
