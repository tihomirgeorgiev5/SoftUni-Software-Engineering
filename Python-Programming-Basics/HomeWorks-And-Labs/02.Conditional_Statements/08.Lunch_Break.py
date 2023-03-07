import math

serial_name = input()
episode_length = int(input())
pause_length = int(input())

lunch_time = pause_length / 8
relax_time = pause_length / 4

total_time_pause_before_watching = pause_length - lunch_time - relax_time
total_time = abs(episode_length - total_time_pause_before_watching)
#total_time = math.ceil(episode_length - total_time_pause_before_watching)


if total_time_pause_before_watching >= episode_length:
    print(f'You have enough time to watch {serial_name} and left with {math.ceil(total_time)} minutes free time.')
else:
    print(f"You don't have enough time to watch {serial_name}, you need {math.ceil(total_time)} more minutes.")