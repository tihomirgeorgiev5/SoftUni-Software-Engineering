
name_animal = input()
class_animal = ''

if name_animal == 'dog':
    class_animal = 'mammal'
elif name_animal == 'crocodile' or name_animal == 'tortoise' or name_animal == 'snake':
    class_animal = 'reptile'
else:
    class_animal = 'unknown'

print(class_animal)