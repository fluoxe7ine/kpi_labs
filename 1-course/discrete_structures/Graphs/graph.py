#defining some graph
point_list = [
    [1,2,3], #0
    [0,2,3,5], #1
    [0,1,3], #2
    [0,1,2], #3
    [], #4
    [1] #5
]

#list of visited points
visited = []

def dfs(p):
    visited.append(p)
    for i in point_list[p]:
        if i not in visited:
            dfs(i)

for i in range(len(point_list)):
    if i not in visited:
        dfs(i)
        
print(visited)
