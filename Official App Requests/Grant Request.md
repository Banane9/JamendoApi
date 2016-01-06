Grant Request
=============

This is the request that the official Windows 8 App of Jamendo makes when one logs in with it.

``` http
POST https://api.jamendo.com/v3.0/oauth/grant HTTP/1.1
Accept: */*
Content-type: application/x-www-form-urlencoded
Accept-Language: de-DE,de;q=0.8,en-GB;q=0.5,en;q=0.3
UA-CPU: AMD64
Accept-Encoding: gzip, deflate
User-Agent: Mozilla/5.0 (Windows NT 6.3; Win64; x64; Trident/7.0; MSAppHost/2.0; rv:11.0) like Gecko
Host: api.jamendo.com
Content-Length: 121
Connection: Keep-Alive
Cache-Control: no-cache

client_id=<id>&client_secret=<secret>&grant_type=password&username=<username>&password=<password>
```

Sadly, they special cased the `grant_type=password` for themselves.