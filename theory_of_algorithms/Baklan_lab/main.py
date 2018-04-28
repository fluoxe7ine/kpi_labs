fin = open("data.csv", "r") #opening file with data
fY = open("Y.txt", "w")
fZ = open("Z.txt", "w")
#initializing list X
X = []
count = 0

#parsing the data file and adding to X list
for line in fin.readlines():
    buff = line.rstrip().split(',')
    X.append(float(buff[1]))

#calculating the X_max and X_min
X_max = max(X)
X_min = min(X)

#initializing the Y_max and Y_min
Y_max = 5587.65
Y_min = 16.3516

#initializing list Y
Y = []
for i in X:
    Y.append(i * ((Y_max - Y_min) / (X_max - X_min)))

#initializing list Y_tilda
Y_tilda = [5587.65, 5274.41, 4978.31, 4698.64, 4434.92, 4186.111, 3951.71, 3729.31, 3520.00, 3322.44, 3135.96, 2959.96, 2793.83, 2637.21, 2489.21, 2349.32, 2217.46, 2093.00, 1975.53, 1864.66, 1760.00, 1661.22, 1567.98, 1479.98, 1396.91, 1318.51, 1244.51, 1174.66, 1108.73, 1046.50, 987.767, 932.328,
           880.000, 830.609, 783.991, 739.989, 698.456, 659.255, 622.254, 587.330, 554.365, 523.251, 493.883, 466.164, 440.000, 415.305, 391.995, 369.994, 349.228, 329.628, 311.127, 293.665, 277.183, 261.626, 246.942, 233.082, 220.000, 207.652, 195.998, 184.997, 174.614, 164.814, 155.563, 146.832,
           138.591, 130.813, 123.471, 116.541, 110.000, 103.826, 97.9989, 92.4986, 87.3071, 82.4069, 77.7817, 73.4162, 69.2957, 65.4064, 61.7354, 58.2705, 55.0000, 51.9131, 48.9994, 46.2493, 43.6535, 41.2034, 38.8909, 36.7081, 34.6478, 32.7032, 30.8677, 29.1352, 27.5000, 25.9565, 24.4997, 23.1247,
           21.8268, 20.6017, 19.4454, 18.3540, 17.3239, 16.3516]

#copiyng values before changes
Z = []
for i in Y:
    Z.append(i)

for i, Zval in enumerate(Z):
    for j, Yt_val in enumerate(Y_tilda, -1):
        if Y_tilda[j] < Z[i] < Y_tilda[j+1]:
            if Z[i] < (Y_tilda[j] + Y_tilda[j+1]) / 2:
                Z[i] = Y_tilda[j]
            else:
                Z[i] = Y_tilda[j+1]
for i in Z:
    fZ.write(str(i) + '\n')
for i in Y:
    fY.write(str(i) + '\n')
