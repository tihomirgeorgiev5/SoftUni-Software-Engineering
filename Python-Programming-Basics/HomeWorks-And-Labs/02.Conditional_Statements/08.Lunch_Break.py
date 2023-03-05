import math

serial_name = input()
episode_length = int(input())
pause_length = int(input())

lunch_time = pause_length / 8
relax_time = pause_length / 4

total_time_pause_before_watching = pause_length - lunch_time - relax_time
left_time = math.ceil(episode_length - total_time_pause_before_watching)

if episode_length <= total_time_pause_before_watching:
    print(f'You have enough time to watch {serial_name} and left with {left_time} minutes free time.')
else:
    print(f"You don't have enough time to watch {serial_name}, you need {left_time} more minutes.")
