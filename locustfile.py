from locust import HttpUser, task, between



class QuickstartUser(HttpUser):
    wait_time = between(1, 5)

    @task
    def root(self):
        self.client.get("index.html")
    #    #self.client.get("")
        
    @task(1)
    def offer(self):
        self.client.get("pages/offer.html")
    #    #self.client.get("/kurser/")
        
    @task(2)
    def teamstart(self):
        self.client.get("pages/teamstart.html")
    #    #self.client.get("/blog/")
        
    @task(3)
    def about(self):
        self.client.get("pages/about.html")
    #    #self.client.get("/kontakt/")
        
    @task(4)
    def contact(self):
        self.client.get("pages/contact.html")

