length = int(input())
width = int(input())
height = int(input())
percent = float(input())

volume = length * width * height
volume_in_liters = volume * 0.001
needed_volume = volume_in_liters - (volume_in_liters * (percent * 0.01))
print(needed_volume)
