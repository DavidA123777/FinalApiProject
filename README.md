HTTP Methods and API endpoints:
GET:
Get Singers -> /api/singer
Get albums -> /api/albums

POST:
Create singer -> /api/singer
Create Album -> /api/albums

DELETE:
Delete Singer by id -> /api/singer/id
Delete album by Id -> /api/albums/id

Sample Request Body:
Post:
{
“AlbumId”: 1,
“SingerId”: 1,
“AlbumName”: “Music of the Sun”,
“ReleaseYear”: 2005
}

Sample Response Body:
201 created
{
“albumId”: 1,
“albumName”: “Music of the Sun”,
“releaseYear”: 2005,
“singerId”: 1
}