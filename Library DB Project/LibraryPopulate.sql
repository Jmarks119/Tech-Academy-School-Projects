CREATE DATABASE LibraryDB
GO

USE LibraryDB
GO

CREATE TABLE PUBLISHER (
	PublisherId INT PRIMARY KEY IDENTITY(1000,1),
	PublisherName VARCHAR(50) NOT NULL,
	PublisherAddress VARCHAR(50) NOT NULL,
	PublisherPhone VARCHAR(20) NOT NULL
);

CREATE TABLE BOOK (
	BookId INT PRIMARY KEY IDENTITY(100000000,1),
	Title VARCHAR(100) NOT NULL,
	PublisherId INT NOT NULL FOREIGN KEY REFERENCES PUBLISHER(PublisherId)
);

CREATE TABLE BOOK_AUTHORS (
	EntryID INT PRIMARY KEY IDENTITY(1,1),
	BookId INT FOREIGN KEY REFERENCES BOOK(BookId) NOT NULL,
	AuthorName VARCHAR(50) NOT NULL
);

CREATE TABLE LIBRARY_BRANCH (
	BranchId INT PRIMARY KEY IDENTITY(100,1),
	BranchName VARCHAR(50) NOT NULL,
	BranchAddress VARCHAR(50) NOT NULL
);

CREATE TABLE BOOK_COPIES (
	EntryID INT PRIMARY KEY IDENTITY(1,1),
	BookId INT FOREIGN KEY REFERENCES BOOK(BookId) NOT NULL,
	BranchId INT FOREIGN KEY REFERENCES LIBRARY_BRANCH(BranchId) NOT NULL,
	No_Of_Copies INT NOT NULL
);

CREATE TABLE BORROWER (
	CardNo INT PRIMARY KEY IDENTITY(1000000,1),
	MemberName VARCHAR(50) NOT NULL,
	MemberAddress VARCHAR(50) NOT NULL,
	MemberPhone VARCHAR(20) NOT NULL
);

CREATE TABLE BOOK_LOANS (
	EntryID INT PRIMARY KEY IDENTITY(1,1),
	BookId INT FOREIGN KEY REFERENCES BOOK(BookId) NOT NULL,
	BranchId INT FOREIGN KEY REFERENCES LIBRARY_BRANCH(BranchId) NOT NULL,
	CardNo INT FOREIGN KEY REFERENCES BORROWER(CardNo) NOT NULL,
	DateOut DATE NOT NULL,
	DueDate DATE NOT NULL
);

INSERT INTO PUBLISHER (PublisherName, PublisherAddress, PublisherPhone)
	VALUES
	('Austin Chronicle Corp', '3579 Ashton Lane Austin TX 78704', '512-487-5919'),
	('Mountain Voice Publisher', '1886 Glen Falls Road Philadelphia PA 19126', '215-924-5079'),
	('Visualpublishing', '4998 Mill Street Greenville SC 29609', '864-246-2130');

INSERT INTO BOOK (Title, PublisherId)
	VALUES
	('The Lost Tribe', 1000),
	('Colony in Uniform', 1001),
	('Mafia Mercenary', 1002),
	('The Vampire Lamp', 1001),
	('Oak and Sunshine', 1000),
	('Hollow Boogie', 1001),
	('A Gentle Valentine', 1001),
	('The Tavern in the Underworld', 1000),
	('Thieving Assassin', 1002),
	('Portrait in Limelight', 1001),
	('Son of Denial', 1001),
	('Claim of Influence', 1000),
	('Tempting Sarah', 1002),
	('Unicorn and Thorn', 1000),
	('The Lives of Cain', 1002),
	('West Catcher', 1002),
	('The Bath Brigade', 1001),
	('Kate and the Tiger', 1000),
	('An Unbreakable Engagement', 1001),
	('Heir Kid', 1002),
	('Elements of Healing', 1002),
	('Stay Lovely', 1000);

INSERT INTO BOOK_AUTHORS (BookId, AuthorName)
	VALUES
	(100000000, 'Carla Wade'),
	(100000001, 'Stephen King'),
	(100000002, 'Billie Harrison'),
	(100000003, 'Judith Schmidt'),
	(100000004, 'Alicia Fields'),
	(100000005, 'Elbert Garrett'),
	(100000006, 'Ramona Harrington'),
	(100000007, 'Crystal Carlson'),
	(100000008, 'Joann Moody'),
	(100000009, 'Eddie Hughes'),
	(100000010, 'Darren Coleman'),
	(100000011, 'Stephen King'),
	(100000012, 'Levi Jordan'),
	(100000013, 'William Ramos'),
	(100000014, 'Rick Johnston'),
	(100000015, 'Debbie Fowler'),
	(100000016, 'Shannon Dixon'),
	(100000017, 'Michael Norman'),
	(100000018, 'Faith Casey'),
	(100000019, 'Laurie Wade'),
	(100000020, 'Bobby Baldwin'),
	(100000021, 'Bernice Alvarado'),
	(100000021, 'Laurie Rodriguez');

INSERT INTO LIBRARY_BRANCH (BranchName, BranchAddress)
	VALUES
	('Sharpstown', '2815 Mattson Street Portland OR 97204'),
	('Central', '2036 Seneca Drive Portland OR 97205'),
	('Uptown', '633 Godfrey Street Portland OR 97205'),
	('Beaverton', '2278 Illinois Avenue Beaverton OR 97006');

INSERT INTO BOOK_COPIES (BookId, BranchId, No_Of_Copies)
	VALUES
	(100000000, 100, 9),
	(100000001, 100, 10),
	(100000002, 100, 9),
	(100000003, 100, 4),
	(100000004, 100, 6),
	(100000005, 100, 10),
	(100000006, 100, 11),
	(100000007, 100, 8),
	(100000008, 100, 2),
	(100000009, 100, 6),
	(100000010, 100, 11),
	(100000011, 100, 11),
	(100000012, 100, 11),
	(100000013, 100, 6),
	(100000014, 100, 2),
	(100000015, 100, 4),
	(100000016, 100, 9),
	(100000017, 100, 6),
	(100000018, 100, 2),
	(100000019, 100, 6),
	(100000020, 100, 2),
	(100000021, 100, 11),
	(100000000, 101, 5),
	(100000001, 101, 11),
	(100000002, 101, 11),
	(100000003, 101, 3),
	(100000004, 101, 11),
	(100000005, 101, 5),
	(100000006, 101, 3),
	(100000007, 101, 9),
	(100000008, 101, 7),
	(100000009, 101, 6),
	(100000010, 101, 10),
	(100000011, 101, 6),
	(100000012, 101, 3),
	(100000013, 101, 3),
	(100000014, 101, 10),
	(100000015, 101, 4),
	(100000016, 101, 10),
	(100000017, 101, 4),
	(100000018, 101, 6),
	(100000019, 101, 2),
	(100000020, 101, 7),
	(100000021, 101, 11),
	(100000000, 102, 10),
	(100000001, 102, 10),
	(100000002, 102, 6),
	(100000003, 102, 5),
	(100000004, 102, 6),
	(100000005, 102, 5),
	(100000006, 102, 10),
	(100000007, 102, 11),
	(100000008, 102, 4),
	(100000009, 102, 8),
	(100000010, 102, 4),
	(100000011, 102, 2),
	(100000012, 102, 7),
	(100000013, 102, 4),
	(100000014, 102, 9),
	(100000015, 102, 6),
	(100000016, 102, 4),
	(100000017, 102, 10),
	(100000018, 102, 2),
	(100000019, 102, 4),
	(100000020, 102, 9),
	(100000021, 102, 4),
	(100000000, 103, 9),
	(100000001, 103, 9),
	(100000002, 103, 2),
	(100000003, 103, 7),
	(100000004, 103, 9),
	(100000005, 103, 5),
	(100000006, 103, 8),
	(100000007, 103, 11),
	(100000008, 103, 5),
	(100000009, 103, 10),
	(100000010, 103, 4),
	(100000011, 103, 9),
	(100000012, 103, 4),
	(100000013, 103, 9),
	(100000014, 103, 2),
	(100000015, 103, 11),
	(100000016, 103, 2),
	(100000017, 103, 4),
	(100000018, 103, 5),
	(100000019, 103, 3),
	(100000020, 103, 7),
	(100000021, 103, 9);

INSERT INTO BORROWER (MemberName, MemberAddress, MemberPhone)
	VALUES
	('Cornelius R Reese', '4848 Terra Cotta Street', '218-494-4823'),
	('James C Johnson', '3970 Little Acres Lane', '217-937-5792'),
	('Jacqueline C Savell', '1737 Broadcast Drive', '704-200-0986'),
	('James T Kearney', '1348 Wiseman Street', '865-387-8729'),
	('Arlene A Brandes', '982 Shingleton Road', '269-320-3871'),
	('Charles A Baker', '4379 Broadway Avenue', '423-780-1191'),
	('Mary A Carmichael', '327 Patterson Road', '718-845-0156'),
	('Melinda E Davison', '1189 Green Gate Lane', '443-747-3931'),
	('Anthony J Gilbert', '880 Clearview Drive', '303-689-8770'),
	('Jesus E Downs', '3359 Breezewood Court', '620-373-8261'),
	('George J Levay', '925 Briercliff Road', '718-656-2630'),
	('Larry R Horn', '4367 Hidden Pond Road', '615-738-8843');

INSERT INTO BOOK_LOANS (BookId, BranchId, CardNo, DateOut, DueDate)
	VALUES
	(100000014, 101, 1000000, '2018-03-29', '2018-04-12'),
	(100000006, 101, 1000000, '2018-03-25', '2018-04-08'),
	(100000003, 101, 1000000, '2018-03-26', '2018-04-09'),
	(100000002, 101, 1000000, '2018-03-23', '2018-04-06'),
	(100000015, 101, 1000000, '2018-04-03', '2018-04-17'),
	(100000003, 102, 1000001, '2018-04-05', '2018-04-19'),
	(100000006, 102, 1000001, '2018-03-24', '2018-04-07'),
	(100000003, 102, 1000003, '2018-03-24', '2018-04-07'),
	(100000008, 102, 1000003, '2018-03-26', '2018-04-09'),
	(100000009, 102, 1000003, '2018-03-31', '2018-04-14'),
	(100000004, 102, 1000003, '2018-03-25', '2018-04-08'),
	(100000015, 102, 1000003, '2018-04-02', '2018-04-16'),
	(100000020, 102, 1000003, '2018-03-27', '2018-04-10'),
	(100000013, 102, 1000003, '2018-03-27', '2018-04-10'),
	(100000001, 102, 1000003, '2018-04-04', '2018-04-18'),
	(100000012, 102, 1000003, '2018-04-06', '2018-04-20'),
	(100000015, 101, 1000004, '2018-03-29', '2018-04-12'),
	(100000007, 101, 1000004, '2018-03-25', '2018-04-08'),
	(100000020, 101, 1000004, '2018-04-02', '2018-04-16'),
	(100000010, 101, 1000006, '2018-03-27', '2018-04-10'),
	(100000006, 101, 1000006, '2018-03-29', '2018-04-12'),
	(100000011, 101, 1000006, '2018-04-02', '2018-04-16'),
	(100000016, 101, 1000006, '2018-04-06', '2018-04-20'),
	(100000002, 100, 1000007, '2018-04-03', '2018-04-17'),
	(100000012, 100, 1000007, '2018-03-27', '2018-04-10'),
	(100000014, 100, 1000007, '2018-03-24', '2018-04-07'),
	(100000011, 100, 1000007, '2018-03-27', '2018-04-10'),
	(100000019, 100, 1000007, '2018-03-31', '2018-04-14'),
	(100000007, 100, 1000007, '2018-03-31', '2018-04-14'),
	(100000013, 100, 1000007, '2018-03-23', '2018-04-06'),
	(100000020, 100, 1000007, '2018-04-05', '2018-04-19'),
	(100000010, 100, 1000007, '2018-03-26', '2018-04-09'),
	(100000006, 100, 1000007, '2018-03-29', '2018-04-12'),
	(100000020, 101, 1000008, '2018-04-05', '2018-04-19'),
	(100000004, 101, 1000008, '2018-04-04', '2018-04-18'),
	(100000010, 101, 1000008, '2018-04-06', '2018-04-20'),
	(100000008, 101, 1000008, '2018-04-05', '2018-04-19'),
	(100000015, 101, 1000008, '2018-03-24', '2018-04-07'),
	(100000021, 101, 1000008, '2018-03-27', '2018-04-10'),
	(100000007, 103, 1000009, '2018-03-24', '2018-04-07'),
	(100000005, 103, 1000009, '2018-03-30', '2018-04-13'),
	(100000012, 103, 1000009, '2018-03-31', '2018-04-14'),
	(100000004, 103, 1000009, '2018-03-25', '2018-04-08'),
	(100000002, 103, 1000009, '2018-03-28', '2018-04-11'),
	(100000021, 103, 1000009, '2018-04-01', '2018-04-15'),
	(100000011, 103, 1000009, '2018-03-26', '2018-04-09'),
	(100000017, 103, 1000009, '2018-03-31', '2018-04-14'),
	(100000000, 103, 1000009, '2018-04-05', '2018-04-19'),
	(100000015, 103, 1000009, '2018-03-28', '2018-04-11'),
	(100000015, 101, 1000010, '2018-03-28', '2018-04-11'),
	(100000005, 101, 1000010, '2018-03-28', '2018-04-11'),
	(100000017, 101, 1000010, '2018-04-06', '2018-04-20'),
	(100000004, 101, 1000010, '2018-03-24', '2018-04-07'),
	(100000011, 101, 1000010, '2018-04-03', '2018-04-17'),
	(100000000, 101, 1000010, '2018-04-06', '2018-04-20'),
	(100000003, 101, 1000010, '2018-03-25', '2018-04-08'),
	(100000005, 103, 1000011, '2018-03-27', '2018-04-10'),
	(100000017, 103, 1000011, '2018-03-27', '2018-04-10'),
	(100000001, 103, 1000011, '2018-03-31', '2018-04-14'),
	(100000007, 103, 1000011, '2018-03-28', '2018-04-11'),
	(100000000, 103, 1000011, '2018-03-23', '2018-04-06'),
	(100000021, 103, 1000011, '2018-04-02', '2018-04-16'),
	(100000019, 103, 1000011, '2018-03-23', '2018-04-06');