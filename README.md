<h1>HTTP Methods and API endpoints:</h1>
<h2>GET:</h2>                                                                                                                                                              <ul>
  <li>Get Singers -> /api/singer</li>
  <li>Get albums -> /api/albums</li>

<h2>POST:</h2>                                                                                                                                                         <ul>
  <li>Create singer -> /api/singer</li>
  <li>Create Album -> /api/albums</li>
</ul>

  <h2>DELETE:</h2>                                                                                                                                                       <ul>
    <li>Delete Singer by id -> /api/singer/id</li>
    <li>Delete album by Id -> /api/albums/id</li>
  </ul>

<h1>Sample Request Body:</h1>
 <h2>Post:</h2>
{
“AlbumId”: 1,
“SingerId”: 1,
“AlbumName”: “Music of the Sun”,
“ReleaseYear”: 2005
}

<h1>Sample Response Body:</h1>
<h2>201 created</h2>
{
“albumId”: 1,
“albumName”: “Music of the Sun”,
“releaseYear”: 2005,
“singerId”: 1
}
