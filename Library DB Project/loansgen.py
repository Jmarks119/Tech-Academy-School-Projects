import random
import datetime

borrowers_set = list(range(1000000, 1000012))
borrowers_set.remove(1000005)
borrowers_set.remove(1000002)
book_set = range(100000000, 100000022)
branch_set = range(100, 104)

def random_dateout():
    todays_date = datetime.date.today()
    return(todays_date - datetime.timedelta(days=random.randint(0,14)))

for member in borrowers_set:
    member_branch = random.choice(branch_set)
    for book in random.sample(book_set, random.randint(1,10)):
        date_out = random_dateout()
        due_date = date_out + datetime.timedelta(days=14)
        print("({}, {}, {}, '{}', '{}'),".format(book, member_branch, member, date_out, due_date))

