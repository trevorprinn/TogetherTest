# Trevor Prinn - Together Test App

The UI for the app is in Blazor, and the code for the page is in `Pages\Index.razor`.

## Database

The Database is a simple EF context with a single table. The post code has not
been normalised into a separate table, but that might be done in a more complex
system.

The database table contains a computed field for indexing on post code, which is always
upper case and with spaces removed. I put this in to experiment with partial postcodes
(and it is still used in the UI for the lookup) but I'm not sure that is really a good
idea, and the map lookup doesn't really work with partial post codes anyway.

The last prices are stored in the address table. In practice, there would be more
likely a series of prices indexed on address id and date.

The database itself is in the bacpac file.

The connection string for the database is in `appsettings.json`,
under `ConnectionStrings/AddressesContext`.

## UI

The post codes are case insensitive. They are tested against a modified version
of the government's recommended post code regular expression. In practice, this
would need a bit more research. The post codes are only validated for format, not
to ensure they actually exist.

### Map

The map is a simple embedded google map showing the post code location, it it is
valid (if not, it shows some arbitrary area). To show where the post code is in
the country (a map of the country with a marker for the post code)
would be a more complex problem. The easiest way I can see to do it would
be to use the google static maps API, which is a PAYG service.

## Logging

A simple log4net configuration has been included for logging.

## Test data

There is a small amount of test data in the database.

|Post Code|Addresses|
|---------|---------|
|LS1 3ED|2|
|BD1 4AG|1|
|LS2 9JT|1|

