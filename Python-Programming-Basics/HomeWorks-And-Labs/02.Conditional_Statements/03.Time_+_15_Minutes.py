hour = int(input())
minutes = int(input())

total_minutes = hour * 60 + minutes + 15

hour = total_minutes // 60
minutes = total_minutes % 60

if hour > 23:
    hour = 0

if minutes < 10:
     print(f'{hour}:0{minutes}')
else:
    print(f'{hour}:{minutes}')
