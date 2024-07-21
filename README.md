# Tour Agency Management Application

Developed using Visual C# WinForms, this Windows Forms application simplifies tour agency operations with two main components: Administration and Client.

Administration:

Data Management: Update details for:
Tours/Destinations: ID, location, country, price, discount, duration, total seats, date.
Users: ID, name, username, password, user type (admin/client).
Reservations: User ID, tour ID, total price, reserved seats, with automatic timestamp logging.
Client:

Login and Dashboard: View upcoming reservations with options to add, edit, or delete.
Tour Booking: Filter tours by location and reserve for a selected number of people (limited by available seats).
Conflict Prevention: Prevents booking overlapping tours.
Automatic Pricing: Calculates total cost automatically.
History Search: Filter past and future reservations by date.
Key Features:

Data Integrity: Prevents deletion of users with existing reservations. Unique IDs are maintained without client visibility.
File Storage: Data is saved via XML serialization.
User Feedback: Provides success and error messages for actions taken.
