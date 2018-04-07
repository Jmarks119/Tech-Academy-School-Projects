USE LibraryDB
GO

CREATE PROC StoredProcedure6
AS
BEGIN
	SELECT MemberName, MemberAddress, COUNT(EntryId) AS [Total Checked Out Books:]
		FROM BORROWER MEMBER
		INNER JOIN BOOK_LOANS LOANS ON MEMBER.CardNo = LOANS.CardNo
		GROUP BY MemberName, MemberAddress
		HAVING COUNT(EntryId) > 5
END
GO