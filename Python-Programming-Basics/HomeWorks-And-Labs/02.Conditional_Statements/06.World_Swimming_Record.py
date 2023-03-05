import math

record = float(input())
distance_meters = float(input())
swimming_time_seconds = float(input())

total_time = distance_meters * swimming_time_seconds
additional_time = math.floor(distance_meters / 15) * 12.5

total_time_ivan = total_time + additional_time

if total_time_ivan < record:
    print(f'Yes, he succeeded! The new world record is {total_time_ivan:.2f} seconds.')
else:
    print(f'No, he failed! He was {(total_time_ivan - record):.2f} seconds slower.')