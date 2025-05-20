# Planing of a modular Library Management System

## System Classes

### Book
- Responsibility: Handling books names, authors and ISBN's.
- Module: LibraryManagement.BookModule
- Namespace: LibraryManagement.Book

### User
- Responsibility: Handling users, including books loans
- Module: LibraryManagement.UserModule
- Namespace: LibraryManagement.User

### Loan
- Responsibility: Handling books loaning and returning, including checking delays
- Module: LibraryManagement.LoanModule
- Namespace:: LibraryManagement.Loan

### Notification
- Responsibility: Displaying notifications about delays, calculating delayes times, showing summaries
- Module: LibraryManagement.NotificationModule
- Namespace: LibraryManagement.Notification
