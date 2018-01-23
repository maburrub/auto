import web
import json

urls = ('/reportResult', 'HandleRequest')

class HandleRequest():
    
    def __init__(self):
        web.header('Content-Type', 'text/json; charset=utf-8')
       
    def POST(self, car_id=None):
		print "---- reporting test result : ", web.data()
		return web.data()
    
app = web.application(urls, globals())

if __name__ == "__main__":
    app.run()

