import random

book_id = 100000000
while True:
    author = input("> ")
    print("({}, '{}'),".format(book_id, author))
    if random.randint(1, 10) == 10:
        continue
    else:
        book_id += 1
