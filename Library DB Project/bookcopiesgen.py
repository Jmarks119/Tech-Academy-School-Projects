import random

for branch in range(100,104):
    for book in range(100000000,100000022):
        print("({}, {}, {}),".format(book, branch, random.randint(2,11)))
