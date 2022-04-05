ALTER TABLE Supplier
 ADD CONSTRAINT Suplier_Contact_Length
 CHECK ( LEN(contacts)=10 )
GO