HttpRequest request = HttpRequest.newBuilder()
		.uri(URI.create("https://face-similarity.p.rapidapi.com/FaceSimilar"))
		.header("content-type", "application/x-www-form-urlencoded")
		.header("x-rapidapi-key", "f485496ab8msh2ea068a0bbe333cp179f86jsn2b4afe8962dd")
		.header("x-rapidapi-host", "face-similarity.p.rapidapi.com")
		.method("POST", HttpRequest.BodyPublishers.ofString("imageBase64=%3CREQUIRED%3E"))
		.build();
HttpResponse<String> response = HttpClient.newHttpClient().send(request, HttpResponse.BodyHandlers.ofString());
System.out.println(response.body());
