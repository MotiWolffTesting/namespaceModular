# תכנון מערכת מודולרית לניהול ספרייה

## מחלקות במערכת

### 1. Book
- **אחריות:** ניהול כותר הספר, המחבר, ומספר ה-ISBN.
- **מודול:** `LibraryManagement.BookModule`
- **Namespace:** `LibraryManagement.Book`

### 2. User
- **אחריות:** ניהול פרטי המשתמש, כולל השאלות והחזרות של ספרים.
- **מודול:** `LibraryManagement.UserModule`
- **Namespace:** `LibraryManagement.User`

### 3. Loan
- **אחריות:** ניהול פעולות השאלה והחזרה של ספרים, כולל מעקב אחרי איחורים.
- **מודול:** `LibraryManagement.LoanModule`
- **Namespace:** `LibraryManagement.Loan`

### 4. Notification
- **אחריות:** הצגת התראות על איחורים, חישוב זמן איחור, הצגת סיכומים.
- **מודול:** `LibraryManagement.NotificationModule`
- **Namespace:** `LibraryManagement.Notification`

---

## תכנון המערכת לפי מודולים

### BookModule
- **אחריות:** כל מה שקשור בספרים, כולל שמירה של כותר, מחבר, ו-ISBN.
- **Namespace:** `LibraryManagement.Book`

### UserModule
- **אחריות:** ניהול פרטי המשתמשים, כולל פעולות השאלה והחזרה.
- **Namespace:** `LibraryManagement.User`

### LoanModule
- **אחריות:** פעולות השאלה והחזרה של ספרים, כולל ניהול זמני ההשאלה וחישוב איחורים.
- **Namespace:** `LibraryManagement.Loan`

### NotificationModule
- **אחריות:** הצגת התראות למשתמשים על איחורים והצגת סיכומים כלליים.
- **Namespace:** `LibraryManagement.Notification`
