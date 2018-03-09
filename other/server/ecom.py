import web
urls = ('/catalog', 'get_catalog')  
app = web.application(urls, globals())
                
class get_catalog:        
    def GET(self):
        return open('data/catalog.json', 'r').read()
if __name__ == "__main__":
    app.run()
