USE LibraryDB
GO

CREATE PROC StoredProcedure7
AS
BEGIN
	SELECT Title, No_Of_Copies
		FROM BOOK
		INNER JOIN BOOK_COPIES COPIES ON BOOK.BookId = COPIES.BookId
		INNER JOIN LIBRARY_BRANCH BRANCH ON BRANCH.BranchId = COPIES.BranchId
		INNER JOIN BOOK_AUTHORS AUTHOR ON BOOK.BookId = AUTHOR.BookId
		WHERE AuthorName = 'Stephen King' AND BranchName = 'Central'
END
GO