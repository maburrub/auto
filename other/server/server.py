#!/usr/bin/env python
import web
import json
import time

urls = ('/api/v1/exReq', 'post_exReq')
        
app = web.application(urls, globals())
    	    	
class post_exReq:        
    def POST(self):
        return open('data/exReq.json', 'r').read()

if __name__ == "__main__":
    app.run()
