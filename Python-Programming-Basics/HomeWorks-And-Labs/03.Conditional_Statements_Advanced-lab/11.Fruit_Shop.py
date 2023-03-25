
fruit = input()
day_of_week = input()
qty = float(input())
price = 0
is_input_valid = False


if (day_of_week == 'Saturday' or
    day_of_week == 'Sunday'):
    if fruit == 'banana':
        price = qty * 2.7
        is_input_valid = True
    elif fruit == 'apple':
        price = qty * 1.25
        is_input_valid = True
    elif fruit == 'orange':
        price = qty * 0.9
        is_input_valid = True
    elif fruit == 'grapefruit':
        price = qty * 1.6
        is_input_valid = True
    elif fruit == 'kiwi':
        price = qty * 3
        is_input_valid = True
    elif fruit == 'pineapple':
        price = qty * 5.6
        is_input_valid = True
    elif fruit == 'grapes':
        price = qty * 4.2
        is_input_valid = True


elif (day_of_week == 'Monday' or
    day_of_week == 'Tuesday' or
    day_of_week == 'Wednesday' or
    day_of_week == 'Thursday' or
    day_of_week == 'Friday'):
    if fruit == 'banana':
        price = qty * 2.5
        is_input_valid = True
    elif fruit == 'apple':
        price = qty * 1.2
        is_input_valid = True
    elif fruit == 'orange':
        price = qty * 0.85
        is_input_valid = True
    elif fruit == 'grapefruit':
        price = qty * 1.45
        is_input_valid = True
    elif fruit == 'kiwi':
        price = qty * 2.7
        is_input_valid = True
    elif fruit == 'pineapple':
        price = qty * 5.5
        is_input_valid = True
    elif fruit == 'grapes':
        price = qty * 3.85
        is_input_valid = True

if is_input_valid:
   print(f"{price:.2f}")
else:
   print('error')







