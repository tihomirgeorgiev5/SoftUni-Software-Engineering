
animal_name = input()
animal_class = ''

if animal_name == 'dog':
    animal_class = 'mammal'
elif animal_name == 'crocodile':
    animal_class = 'reptile'
elif animal_name == 'tortoise':
    animal_class = 'reptile'
elif animal_name == 'snake':
    animal_class = 'reptile'
else:
    animal_class = 'unknown'

print(animal_class)
