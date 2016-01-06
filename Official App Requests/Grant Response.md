Grant Response
=============

This is the response that the official Windows 8 App of Jamendo gets back when one logs in with it.

``` http
HTTP/1.1 200 OK
Server: ngx_openresty
Date: Tue, 05 Jan 2016 18:03:01 GMT
Content-Type: application/json
Connection: keep-alive
Vary: Accept-Encoding
Vary: Host
Cache-Control: no-store, no-cache, must-revalidate, post-check=0, pre-check=0
Pragma: no-cache
Expires: Thu, 19 Nov 1981 08:52:00 GMT
Set-Cookie: jamloc=nl_BE; expires=Thu, 04-Feb-2016 18:03:01 GMT; path=/; domain=.api.jamendo.com
Set-Cookie: jamuserid=deleted; expires=Thu, 01-Jan-1970 00:00:01 GMT; path=/; domain=.jamendo.com
Access-Control-Allow-Origin: *
Access-Control-Allow-Credentials: false
Access-Control-Allow-Methods: GET, POST
Set-Cookie: jamuserid=<id>; expires=Sat, 05-Mar-2016 18:03:01 GMT; path=/; domain=.jamendo.com
Set-Cookie: jamhasaccount=1; expires=Tue, 19-Jan-2016 18:03:01 GMT; path=/; domain=.jamendo.com
Set-Cookie: facebookplay=undefined; expires=Sat, 05-Mar-2016 18:03:01 GMT; path=/; domain=.api.jamendo.com
Content-Length: 174

{"access_token":"<token>","expires_in":7200,"token_type":"bearer","scope":"music","refresh_token":"<refresh_token>"}
```

Sadly, they special cased the used `grant_type=password` for themselves.