
day_of_week = input()
result = ''

if day_of_week == 'Monday':
    result = 'Working day'
elif day_of_week == 'Tuesday':
    result = 'Working day'
elif day_of_week == 'Wednesday':
    result = 'Working day'
elif day_of_week == 'Thursday':
    result = 'Working day'
elif day_of_week == 'Friday':
    result = 'Working day'
elif day_of_week == 'Saturday':
    result = 'Weekend'
elif day_of_week == 'Sunday':
    result = 'Weekend'
else:
    result = 'Error'

print(result)