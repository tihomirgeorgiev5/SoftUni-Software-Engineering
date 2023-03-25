
town = input()
sells_volume = float(input())
percent = 0
is_valid_town = False

if 0 <= sells_volume <= 500:
    if town == 'Sofia':
        percent = 0.05
        is_valid_town = True
    elif town == 'Varna':
        percent = 0.045
        is_valid_town = True
    elif town == 'Plovdiv':
        percent = 0.055
        is_valid_town = True
elif 500 < sells_volume <= 1000:
    if town == 'Sofia':
        percent = 0.07
        is_valid_town = True
    elif town == 'Varna':
        percent = 0.075
        is_valid_town = True
    elif town == 'Plovdiv':
        percent = 0.08
        is_valid_town = True
elif 1000 < sells_volume <= 10000:
    if town == 'Sofia':
        percent = 0.08
        is_valid_town = True
    elif town == 'Varna':
        percent = 0.1
        is_valid_town = True
    elif town == 'Plovdiv':
        percent = 0.12
        is_valid_town = True
elif sells_volume > 10000:
    if town == 'Sofia':
        percent = 0.12
        is_valid_town = True
    elif town == 'Varna':
        percent = 0.13
        is_valid_town = True
    elif town == 'Plovdiv':
        percent = 0.145
        is_valid_town = True

if is_valid_town:
    total = sells_volume * percent
    print(f"{total:.2f}")
else:
    print('error')




